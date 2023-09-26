namespace DesignPatternsGoF.Behavioral.Command
{
    public class EmailCommand : ICommand
    {
        private readonly EmailService emailService;
        private readonly string to;
        private readonly string message;

        public EmailCommand(EmailService emailService, string to, string message)
        {
            this.emailService = emailService;
            this.to = to;
            this.message = message;
        }

        public void Execute()
        {
            emailService.SendEmail(to, message);
        }
    }
}
