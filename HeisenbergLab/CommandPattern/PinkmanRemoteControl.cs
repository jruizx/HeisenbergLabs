namespace HeisenbergLab.CommandPattern
{
    public class PinkmanRemoteControl
    {
        private readonly ICommand[] commands;
        private const int buffer = 7;

        public PinkmanRemoteControl()
        {
            commands = new ICommand[buffer];
        }

        public void SetCommand(int slot, ICommand command)
        {
            if (slot >= 0 && slot < buffer)
            {
                commands[slot] = command;
            }
        }

        public void PressButton(int slot)
        {
            if (slot >= 0 && slot < buffer && commands[slot] != null)
            {
                commands[slot].Execute();
            }
        }
    }
}
