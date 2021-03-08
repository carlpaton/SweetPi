using SweetPi.Domain.Models;

namespace SweetPi.Application.Common.Interfaces
{
    public interface ILedService
    {

        // TODO ~ 1. Rename `HandleRequest` to `HandleWrite(int pin, LedState state)` and add `HandleRead(int pin)`
        // TODO ~ 2. Rename `ILedService` to `IPinService`
        // TODO - 3. Add a new service `IBoardService` it needs to return the pins we can use depending on the set PinNumberingScheme (logical 18,19,21 or board GPIO24,GPIO10,GPIO09) - See: https://carlpaton.github.io/2019/12/pi-resources/
        // TODO ~ 4. Validate input to `/leds` to be with in `IBoardService` values. ie: if we are using logical the given pin cannot be 100 (or the 3v,5v,GND pins)


        /// <summary>
        /// For the given `ledModel.Pin` handle the request to turn it off/on based on `ledModel.State`
        /// </summary>
        /// <param name="ledModel"></param>
        void HandleRequest(LedModel ledModel);
    }
}
