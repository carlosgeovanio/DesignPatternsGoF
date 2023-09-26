namespace DesignPatternsGoF.Behavioral.ChainOfResponsibility
{
    public class BiometricAuthenticationHandler : AuthenticationHandler
    {
        public override bool Authenticate(AuthenticationRequest request)
        {
            if (request.IsBiometricAuthenticated)
            {
                Console.WriteLine("Biometric authentication successful.");
                return true;
            }

            return NextHandler != null && NextHandler.Authenticate(request);
        }
    }
}
