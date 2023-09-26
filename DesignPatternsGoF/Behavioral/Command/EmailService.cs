namespace DesignPatternsGoF.Behavioral.Command
{
    public class EmailService
    {
        public void SendEmail(string to, string message)
        {
            Console.WriteLine($"E-mail enviado para {to}: {message}");
        }
    }
}
