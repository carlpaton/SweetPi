using SweetPi.Application.Common.Interfaces;
using SweetPi.Domain.Interfaces;
using SweetPi.Domain.Models;

namespace SweetPi.Application.Services
{
    public class LedService : ILedService
    {
        private readonly IGpioControllerRepository _repository;

        public LedService(IGpioControllerRepository repository)
        {
            _repository = repository;
        }

        public void HandleRequest(LedModel ledModel)
        {
            // TODO - what if the pin is already open?
            _repository.OpenPinForOutPut(ledModel.Pin);

            switch (ledModel.State)
            {
                case LedState.On:
                    _repository.WriteHigh(ledModel.Pin);
                    break;
                default:
                    _repository.WriteLow(ledModel.Pin);
                    break;
            }
        }
    }
}
