namespace In.ProjectEKA.HipService.UserAuth.Model
{
    public class AuthConfirmCredential
    {
        public string authCode { get; }
        public Demographics demographic { get; }

        public AuthConfirmCredential(string authCode, Demographics demographics)
        {
            this.authCode = authCode;
            this.demographic = demographics;
        }
    }
}