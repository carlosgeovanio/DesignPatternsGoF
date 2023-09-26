namespace DesignPatternsGoF.Behavioral.ChainOfResponsibility
{
    public class AuthenticationRequest
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
        public bool IsBiometricAuthenticated { get; set; }
    }
}
