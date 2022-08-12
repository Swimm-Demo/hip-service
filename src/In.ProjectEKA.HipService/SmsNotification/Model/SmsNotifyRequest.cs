using In.ProjectEKA.HipService.Common.Model;

namespace In.ProjectEKA.HipService.SmsNotification.Model
{
    public class SmsNotifyRequest
    {
        public string phoneNo { get; }
        public SmsNotifyRequest(string phoneNo)
        {
            this.phoneNo = phoneNo;
        }
    }
}