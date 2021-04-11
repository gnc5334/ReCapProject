using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CarDetailDto:IDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public decimal DailyPrice { get; set; }
        public int ModelYear { get; set; }
        public string PreviewImagePath { get; set; }
        public int MinFindeksScore { get; set; }
        public byte ABS { get; set; }
        public byte Fuel { get; set; }
        public byte Gear { get; set; }
        public byte ParkingSensor { get; set; }
        public bool Status { get; set; }

     
    }
}
