namespace DesignPatternsGoF.Behavioral.ChainOfResponsibility
{
    public class UsernamePasswordAuthenticationHandler : AuthenticationHandler
    {
        public override bool Authenticate(AuthenticationRequest request)
        {
            if (!string.IsNullOrWhiteSpace(request.UserName) && !string.IsNullOrWhiteSpace(request.Password))
            {
                Console.WriteLine("Username and password successful");
                return true;
            }

            return NextHandler != null && NextHandler.Authenticate(request);
        }
    }
}
