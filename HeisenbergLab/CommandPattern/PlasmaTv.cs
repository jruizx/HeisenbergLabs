using System;

namespace HeisenbergLab.CommandPattern
{
    public class PlasmaTv
    {
        public void On()
        {
            Console.WriteLine("The 60\" plasma TV is turned on.");
        }

        public void Off()
        {
            Console.WriteLine("The 60\" plasma TV is turned off.");
        }

        public void SetChannel(int channelNumber)
        {
            Console.WriteLine(string.Format("The channel is changed to: {0}", channelNumber));
        }

        public void IncreaseVolume()
        {
            Console.WriteLine("The volume is increased");
        }

        public void DecreaseVolume()
        {
            Console.WriteLine("The volume is decreased");
        }
    }
}
