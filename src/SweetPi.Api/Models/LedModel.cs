using Microsoft.AspNetCore.Mvc;
using SweetPi.Domain.Models;
using SweetPi.Infrastructure.ModelBinder;

namespace SweetPi.Api.Models
{
    [ModelBinder(BinderType = typeof(FormDataJsonBinder))]
    public class LedModel
    {
        public int Pin { get; set; }

        public LedState State { get; set; }
    }
}
