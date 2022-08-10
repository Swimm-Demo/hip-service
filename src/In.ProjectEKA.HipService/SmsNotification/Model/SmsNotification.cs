namespace In.ProjectEKA.HipService.SmsNotification.Model
{
    public class SmsNotification
    {
        public string phoneNo { get; }
        public SmsNotifyHip hip { get; }

        public SmsNotification(string phoneNo, SmsNotifyHip hip)
        {
            this.phoneNo = phoneNo;
            this.hip = hip;
        }
    }
}