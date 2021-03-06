using SweetPi.Domain.Models;

namespace SweetPi.Api.Models
{
    public class LedModel
    {
        public int Pin { get; set; }
        public LedState State { get; set; }
    }
}
