using System;

namespace HeisenbergLab.CommandPattern
{
    public class XBoxOne
    {
        public void On()
        {
            Console.WriteLine("The xbox is running.");
        }

        public void Off()
        {
            Console.WriteLine("Shutdown the xbox.");
        }

        public void OpenBlueRay()
        {
            Console.WriteLine("Open the BlueRay to introduce a BlueRay disc.");
        }

        public void CloseBlueRay()
        {
            Console.WriteLine("Close the BlueRay");
        }
    }
}
