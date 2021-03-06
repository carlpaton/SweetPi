using SweetPi.Domain.Interfaces;
using System.Device.Gpio;

namespace SweetPi.Infrastructure.Repositories
{
    public class GpioControllerRepository : IGpioControllerRepository
    {
        private readonly GpioController _context;

        public GpioControllerRepository()
        {
            // GPIO pins - https://carlpaton.github.io/2019/12/pi-resources/
            // TODO : Having this state will allow the context to be shared but Im not sure what that will look like for unit tests?
            // TODO : Consider `PinNumberingScheme` for Logical/Board - logical pin numbering scheme is default
            _context = new GpioController();
        }

        public void OpenPinForOutPut(int pin)
        {
            _context.OpenPin(pin, PinMode.Output);
        }

        public void WriteHigh(int pin)
        {
            _context.Write(pin, PinValue.High);
        }

        public void WriteLow(int pin)
        {
            _context.Write(pin, PinValue.Low);
        }
    }
}
