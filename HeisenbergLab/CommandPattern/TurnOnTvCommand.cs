namespace HeisenbergLab.CommandPattern
{
    public class TurnOnTvCommand : ICommand
    {
        private readonly PlasmaTv receiver;

        public TurnOnTvCommand(PlasmaTv receiver)
        {
            this.receiver = receiver;
        }
        
        public void Execute()
        {
            receiver.On();
        }
    }
}
