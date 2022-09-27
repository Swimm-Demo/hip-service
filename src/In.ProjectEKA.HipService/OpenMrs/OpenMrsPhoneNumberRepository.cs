using System.Text.Json;
using System.Threading.Tasks;
using In.ProjectEKA.HipLibrary.Patient;

namespace In.ProjectEKA.HipService.OpenMrs
{
    public class OpenMrsPhoneNumberRepository : IPhoneNumberRepository
    {
        private readonly IOpenMrsClient openMrsClient;
        private readonly OpenMrsConfiguration openMrsConfiguration;
        public OpenMrsPhoneNumberRepository(IOpenMrsClient openMrsClient, OpenMrsConfiguration openMrsConfiguration)
        {
            this.openMrsClient = openMrsClient;
            this.openMrsConfiguration = openMrsConfiguration;
        }

        public async Task<string> GetPhoneNumber(string patientReferenceNumber)
        {
            var openmrsRestPatientPath = $"{DiscoveryPathConstants.OnRestPatientPath}/{patientReferenceNumber}";

            var response = await openMrsClient.GetAsync(openmrsRestPatientPath);
            var content = await response.Content.ReadAsStringAsync();

            var jsonDoc = JsonDocument.Parse(content);
            var root = jsonDoc.RootElement;

            var person = root.GetProperty("person");
            var attributes = person.GetProperty("attributes");

            for (int i = 0; i < attributes.GetArrayLength(); i++)
            {
                var display = attributes[i].GetProperty("display");
                var strlist = display.ToString().Split(" = ");
                if (strlist[0] == openMrsConfiguration.PhoneNumber) {
                    return strlist[1];
                }
            }

            return null;
        }
    }
}