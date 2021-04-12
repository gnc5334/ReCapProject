using Core.Entities;
using Core.Utilities.Attributes.FilterAttributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CarDetailFilterDto : IFilterDto
    {
        [EqualFilter("BrandId")]
        public List<int> BrandId { get; set; }
        [EqualFilter("ColorId")]
        public List<int> ColorId { get; set; }
        [EqualFilter("Id")]
        public List<int> Id { get; set; }
        [EqualFilter("DailyPrice")]
        public List<int> DailyPrice { get; set; }
        public string Description { get; set; }
        [MinFilter("DailyPrice")]
        public int? MinDailyPrice { get; set; }
        [MaxFilter("DailyPrice")]
        public int? MaxDailyPrice { get; set; }

    }
}
