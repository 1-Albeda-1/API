namespace API.Models
{
    public class ReysStatisticModel
    {
        /// <summary>
        /// общее кол-во туров
        /// </summary>
        public int Count { get; set; }
        /// <summary>
        /// общее кол-во пассажиров
        /// </summary>
        public int CountPassangers { get; set; }
        /// <summary>
        /// общее кол-во экипажа
        /// </summary>
        public int CountCrew { get; set; }
        /// <summary>
        /// общая сумма выручки за все рейсрв
        /// </summary>
        public decimal AllPriceReys { get; set; }
    }
}
