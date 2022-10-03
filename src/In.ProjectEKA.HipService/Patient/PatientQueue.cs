using System.ComponentModel.DataAnnotations;

namespace In.ProjectEKA.HipService.Patient
{
    public class PatientQueue
    {
        public string DateTimeStamp { get; }
        public string Profile { get; }
        [Key] public string RequestId { get; }

        public PatientQueue(string requestId, string dateTimeStamp, string profile)
        {
            RequestId = requestId;
            DateTimeStamp = dateTimeStamp;
            Profile = profile;
        }
    }
}