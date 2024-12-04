using CLLampe;
using System.Runtime.CompilerServices;

namespace AppLampe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lamp lamp = new Lamp();
            Remote remote = new Remote(new CommandTurnOnLamp(lamp));
            
            remote.PressButton();

            remote.SetCommand(new CommandTurnOffLamp(lamp));

            remote.PressButton();
        }
    }
}
