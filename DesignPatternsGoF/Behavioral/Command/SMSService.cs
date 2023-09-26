namespace DesignPatternsGoF.Behavioral.Command
{
    public class SMSService
    {
        public void SendSMS(string phoneNumber, string message)
        {
            Console.WriteLine($"SMS enviado para {phoneNumber}: {message}");
        }
    }
}
