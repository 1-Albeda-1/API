using UserStoryAir.Models;

namespace API.Models
{
    public class AddReysModel
    {
        
        /// <summary>
        /// Номер рейса
        /// </summary>
        public decimal NumberReys { get; set; }
        /// <summary>
        /// Тип самолета
        /// </summary>
        public plane Plane { get; set; }
        /// <summary>
        /// Время прибытия
        /// </summary>
        public DateTime arrivalTime { get; set; }
        /// <summary>
        /// Количество пассажиров
        /// </summary>
        public decimal NumberPassengers { get; set; }
        /// <summary>
        /// Количество экипажа
        /// </summary>
        public decimal NumberCrew { get; set; }
        /// <summary>
        /// Сбор на пассажира
        /// </summary>
        public decimal SborP { get; set; }
        /// <summary>
        /// Сбор на экипаж
        /// </summary>
        public decimal SborC { get; set; }
        /// <summary>
        /// Процент надбавки за обслуживание
        /// </summary>
        public decimal allowance { get; set; }
       
    }
}
