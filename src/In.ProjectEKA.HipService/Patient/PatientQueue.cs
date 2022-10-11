using System.ComponentModel.DataAnnotations;
using In.ProjectEKA.HipService.Patient.Model;

namespace In.ProjectEKA.HipService.Patient
{
    public class PatientQueue
    {
        public string DateTimeStamp { get; }
        public string HipCode { get; }
        public PatientDemographics Profile { get; }
        [Key] public string RequestId { get; }

        public PatientQueue(string requestId, string dateTimeStamp, PatientDemographics profile, string hipCode)
        {
            RequestId = requestId;
            DateTimeStamp = dateTimeStamp;
            Profile = profile;
            HipCode = hipCode;
        }
    }
}