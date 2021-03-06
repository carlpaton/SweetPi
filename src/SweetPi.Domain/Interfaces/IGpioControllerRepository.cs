using System.Device.Gpio;

namespace SweetPi.Domain.Interfaces
{
    /// <summary>
    /// This will need to be a Singleton when injected in the application pipeline
    /// </summary>
    public interface IGpioControllerRepository
    {
        /// <summary>
        /// Output used for writing values to a pin.
        /// </summary>
        /// <param name="pin"></param>
        void OpenPinForOutPut(int pin);

        /// <summary>
        /// The value of the pin is high (ON).
        /// </summary>
        void WriteHigh(int pin);

        /// <summary>
        /// The value of the pin is low (OFF).
        /// </summary>
        /// <param name="pin"></param>
        void WriteLow(int pin);
    }
}
