using Core.Entities;


namespace Entities.Concrete
{
    public class Car:IEntity
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
        public int MinFindeksScore { get; set; }
        public byte ABS { get; set; }
        public byte Fuel { get; set; }
        public byte Gear { get; set; }
        public byte ParkingSensor { get; set; }

    }
}
