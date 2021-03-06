using SweetPi.Domain.Models;

namespace SweetPi.Application.Common.Interfaces
{
    public interface ILedService
    {
        // TODO - the service will need a way to expose the state of current pins (OpenPin ~ so writable and then the values low/high)

        /// <summary>
        /// For the given `ledModel.Pin` handle the request to turn it off/on based on `ledModel.State`
        /// </summary>
        /// <param name="ledModel"></param>
        void HandleRequest(LedModel ledModel);
    }
}
