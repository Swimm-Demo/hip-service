using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using In.ProjectEKA.HipLibrary.Patient.Model;
using In.ProjectEKA.HipService.Logger;
using In.ProjectEKA.HipService.OpenMrs;
using In.ProjectEKA.HipService.Patient.Database;
using In.ProjectEKA.HipService.Patient.Model;
using Optional;
using Task = System.Threading.Tasks.Task;

namespace In.ProjectEKA.HipService.Patient
{
    using static Common.Constants;

    public class PatientProfileService : IPatientProfileService
    {
        private const string Gan = "GAN";
        private const string Nat = "NAT";
        private readonly HttpClient _httpClient;
        private readonly OpenMrsConfiguration _openMrsConfiguration;
        private readonly PatientContext patientContext;

        public PatientProfileService(HttpClient httpClient, OpenMrsConfiguration openMrsConfiguration, PatientContext patientContext)
        {
            this._httpClient = httpClient;
            this._openMrsConfiguration = openMrsConfiguration;
            this.patientContext = patientContext;
        }

        public async Task SavePatient(ShareProfileRequest shareProfileRequest)
        {
            var requesId = shareProfileRequest.RequestId;
            var timeStamp = shareProfileRequest.Timestamp.ToString();
            var hipCode = shareProfileRequest.Profile.HipCode;
            var patient = shareProfileRequest.Profile.PatientDemographics;
            var response = await Save(new PatientQueue(requesId, timeStamp, patient, hipCode));
            if(response.HasValue)
                Log.Information("Patient saved to queue");
        }

        private async Task<Option<PatientQueue>> Save(PatientQueue patientQueue)
        {
            try
            {
                await patientContext.PatientQueue.AddAsync(patientQueue).ConfigureAwait(false);
                await patientContext.SaveChangesAsync();
                return Option.Some(patientQueue);
            }
            catch (Exception exception)
            {
                Log.Fatal(exception, exception.StackTrace);
                return Option.None<PatientQueue>();
            }
        }

        private async Task<string> GetPrimaryContactUuid()
        {
            var request = new HttpRequestMessage(HttpMethod.Get,
                _openMrsConfiguration.Url + PATH_OPENMRS_ATTRIBUTE_TYPE + _openMrsConfiguration.PhoneNumber);
            var response = await _httpClient.SendAsync(request).ConfigureAwait(false);
            var content = await response.Content.ReadAsStringAsync();
            var jsonDoc = JsonDocument.Parse(content);
            var root = jsonDoc.RootElement;
            return root.GetProperty("results")[0].GetProperty("uuid").ToString();
        }

        private string GetPrimaryContact(List<Identifier> personIdentifiers)
        {
            foreach (var identifiers in personIdentifiers.Where(identifiers =>
                identifiers.Type.Equals(IdentifierType.MOBILE)))
            {
                return identifiers.Value;
            }
            return "";
        }

        private DateTime GetDateOfBirth(PatientDemographics profilePatientDemographics)
        {
            var dayOfBirth = profilePatientDemographics.DayOfBirth > 0 ? profilePatientDemographics.DayOfBirth : 1;
            var monthOfBirth = profilePatientDemographics.MonthOfBirth > 0
                ? profilePatientDemographics.MonthOfBirth
                : 1;
            var yearOfBirth = profilePatientDemographics.YearOfBirth;
            return new DateTime(Convert.ToInt32(yearOfBirth), Convert.ToInt32(monthOfBirth),
                Convert.ToInt32(dayOfBirth)).ToUniversalTime();
        }

        public bool IsValidRequest(ShareProfileRequest shareProfileRequest)
        {
            var profile = shareProfileRequest?.Profile;
            var demographics = profile?.PatientDemographics;
            return demographics is {HealthId: { }, Identifiers: { }, Name: { },Gender:{}} && Enum.IsDefined(typeof(Gender), demographics.Gender) && demographics.YearOfBirth != 0;
        }

        private async Task<bool> IsExist(string patientIdentifier)
        {
            var request = new HttpRequestMessage(HttpMethod.Get,
                _openMrsConfiguration.Url + PATH_OPENMRS_EXISTING_HEALTHID + patientIdentifier);
            var response = await _httpClient.SendAsync(request).ConfigureAwait(false);
            var content = await response.Content.ReadAsStringAsync();
            return !content.Contains("error");
        }

        private async Task<List<object>> GetIdentifiers(string healthId, string phrAddress)
        {
            var request = new HttpRequestMessage(HttpMethod.Get,
                _openMrsConfiguration.Url + PATH_OPENMRS_IDENTIFIER_TYPE);
            var response = await _httpClient.SendAsync(request).ConfigureAwait(false);
            var content = await response.Content.ReadAsStringAsync();
            var jsonDoc = JsonDocument.Parse(content);
            var root = jsonDoc.RootElement;

            var identifiers = new List<Object>();
            if (root.GetArrayLength() <= 0) return identifiers;
            foreach (var jsonElement in root.EnumerateArray())
            {
                var name = jsonElement.GetProperty("name").ToString();
                switch (name)
                {
                    case "Patient Identifier":
                    {
                        var ganSourceUuid = GetGanSourceUuid(jsonElement);
                        identifiers.Add(new PatientIdentifier(ganSourceUuid, Gan,
                            jsonElement.GetProperty("uuid").ToString()));
                        break;
                    }
                    case "Health ID":
                        identifiers.Add(item: new ExtraPatientIdentifier(healthId,
                            jsonElement.GetProperty("uuid").ToString()));
                        break;
                    case "PHR Address":
                        identifiers.Add(item: new ExtraPatientIdentifier(phrAddress,
                            jsonElement.GetProperty("uuid").ToString()));
                        break;
                    case "National ID":
                        identifiers.Add(new PatientIdentifier(
                            jsonElement.GetProperty("identifierSources")[0].GetProperty("uuid").ToString(), Nat,
                            jsonElement.GetProperty("uuid").ToString()));
                        break;
                }
            }
            return identifiers;
        }

        private string GetGanSourceUuid(JsonElement root)
        {
            var identifierSources =
                root.GetProperty("identifierSources").EnumerateArray();
            return (from sources in identifierSources where sources.GetProperty("prefix").ToString().Equals("GAN") select sources.GetProperty("uuid").ToString()).FirstOrDefault();
        }

        private PatientName GetName(string[] name)
        {
            return name.Length switch
            {
                3 => new PatientName(name[0], name[1], name[2]),
                2 => new PatientName(name[0], null, name[1]),
                _ => new PatientName(name[0], null, null)
            };
        }
        
        public async Task<List<PatientQueue>> GetPatientQueue()
        {
            try
            {
                var patientQueueRequest = patientContext.PatientQueue.ToList().FindAll(
                    patient => DateTime.Compare(DateTime.Now.AddHours(-1),DateTime.Parse(patient.DateTimeStamp)) < _openMrsConfiguration.PatientQueueTimeLimit
                );
                if (patientQueueRequest != null)
                {
                    return patientQueueRequest;
                }
                return new List<PatientQueue>();
            }
            catch (Exception exception)
            {
                Log.Fatal(exception, exception.StackTrace);
                return new List<PatientQueue>();
            }
        }

  
    }
}