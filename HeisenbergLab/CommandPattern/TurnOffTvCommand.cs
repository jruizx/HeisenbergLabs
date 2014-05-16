namespace HeisenbergLab.CommandPattern
{
    public class TurnOffTvCommand : ICommand
    {
        private readonly PlasmaTv receiver;

        public TurnOffTvCommand(PlasmaTv receiver)
        {
            this.receiver = receiver;
        }

        public void Execute()
        {
            receiver.Off();
        }
    }
}
