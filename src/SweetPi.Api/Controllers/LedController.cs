using Microsoft.AspNetCore.Mvc;
using SweetPi.Api.Models;
using SweetPi.Application.Common.Interfaces;
using System;

namespace SweetPi.Api.Controllers
{
    public class LedController : Controller
    {
        // TODO - maybe use mediator / command query responsibility segregation

        private readonly ILedService _ledService;

        public LedController(ILedService ledService) 
        {
            _ledService = ledService;
        }

        [HttpPost("/leds")]
        public ActionResult<LedModel> SetLed([FromForm] LedModel ledModel) 
        {
            Console.WriteLine("ledModel Pin:{0} State:{1}", ledModel.Pin, ledModel.State);

            var domainModel = new Domain.Models.LedModel()
            {
                Pin = ledModel.Pin,
                State = ledModel.State
            };

            _ledService.HandleRequest(domainModel);

            return Ok(ledModel);
        }
    }
}
