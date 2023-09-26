namespace DesignPatternsGoF.Behavioral.Command
{
    public class SMSCommand : ICommand
    {
        private readonly SMSService smsService;
        private readonly string phoneNumber;
        private readonly string message;

        public SMSCommand(SMSService smsService, string phoneNumber, string message)
        {
            this.smsService = smsService;
            this.phoneNumber = phoneNumber;
            this.message = message;
        }

        public void Execute()
        {
            smsService.SendSMS(phoneNumber, message);
        }
    }
}
