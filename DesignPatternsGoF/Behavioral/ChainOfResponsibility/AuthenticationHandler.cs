namespace DesignPatternsGoF.Behavioral.ChainOfResponsibility
{
    public abstract class AuthenticationHandler
    {
        protected AuthenticationHandler NextHandler;

        public void SetNext(AuthenticationHandler handler)
        {
            NextHandler = handler;
        }

        public abstract bool Authenticate(AuthenticationRequest request);
    }
}
