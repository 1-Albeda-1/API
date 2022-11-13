using API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserStoryAir.Models;

namespace API.Controllers
{
    [Route("ReysesReg/[controller]")]
    [ApiController]
    public class ReysController : ControllerBase
    {
        private static readonly IList<Reys> Reyses = new List<Reys>();

        [HttpGet]
        public IEnumerable<Reys> Get()
        {
            return Reyses;
        }
        [HttpGet("stats")]
        public ReysStatisticModel GetStatistic()
        {
            var result = new ReysStatisticModel
            {
                Count = Reyses.Count,
                CountPassangers = Reyses.Count(x => x.NumberPassengers != 0),
                CountCrew = Reyses.Count(x => x.NumberCrew != 0),
                AllPriceReys = Reyses.Sum(x => x.summa),
            };
            return result;
        }
        [HttpPost]
        public Reys Add(AddReysModel model)
        {
            var tour = new Reys
            {
                ID = Guid.NewGuid(),
                NumberReys = model.NumberReys,
                Plane = model.Plane,
                arrivalTime = model.arrivalTime,
                NumberPassengers = model.NumberPassengers,
                NumberCrew = model.NumberCrew,
                SborP = model.SborP,
                SborC = model.SborC,
                allowance = model.allowance,
                summa = (model.NumberPassengers * model.SborP + model.NumberCrew * model.SborC) + model.allowance,

            };
            Reyses.Add(tour);
            return tour;
        }
        //изменение
        [HttpPut("{id:guid}")]
        public Reys Update([FromRoute] Guid id, [FromBody] AddReysModel model)
        {
            var targetReys = Reyses.FirstOrDefault(u => u.ID == id);
            if (targetReys != null)
            {
                targetReys.NumberReys = model.NumberReys;
                targetReys.Plane = model.Plane;
                targetReys.arrivalTime = model.arrivalTime;
                targetReys.NumberPassengers = model.NumberPassengers;
                targetReys.NumberCrew = model.NumberCrew;
                targetReys.SborP = model.SborP;
                targetReys.SborC = model.SborC;
                targetReys.allowance = model.allowance;
                targetReys.summa = (model.NumberPassengers * model.SborP + model.NumberCrew * model.SborC) + model.allowance;
            }
            return targetReys;
        }
        //удаление
        [HttpDelete("{id:guid}")]
        public bool Remove(Guid id)
        {
            var targetReys = Reyses.FirstOrDefault(u => u.ID == id);
            if (targetReys != null)
            {
                return Reyses.Remove(targetReys);
            }
            return false;
        }
    }
}
