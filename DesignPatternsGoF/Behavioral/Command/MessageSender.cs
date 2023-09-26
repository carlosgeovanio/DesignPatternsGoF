namespace DesignPatternsGoF.Behavioral.Command
{
    public class MessageSender
    {
        private readonly List<ICommand> commands = new List<ICommand>();

        public void AddCommand(ICommand command)
        {
            commands.Add(command);
        }

        public void SendMessages()
        {
            foreach (var command in commands)
            {
                command.Execute();
            }
        }
    }
}
