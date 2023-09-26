namespace DesignPatternsGoF.Behavioral.ChainOfResponsibility
{
    public class TokenAuthenticationHandler : AuthenticationHandler
    {
        public override bool Authenticate(AuthenticationRequest request)
        {
            if (!string.IsNullOrWhiteSpace(request.Token))
            {
                Console.WriteLine("Token authentication successful");
                return true;
            }

            return NextHandler != null && NextHandler.Authenticate(request);
        }
    }
}
