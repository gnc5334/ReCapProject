using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentCarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            using (RentCarContext context = new RentCarContext())
            {
                var result = from cr in filter == null ? context.Cars : context.Cars.Where(filter)
                             join b in context.Brands
                                 on cr.BrandId equals b.Id
                             join cl in context.Colors
                                 on cr.ColorId equals cl.Id
                             select new CarDetailDto
                             {
                                 Id = cr.Id,
                                 BrandId = b.Id,
                                 ColorId = cl.Id,
                                 ModelYear = cr.ModelYear,
                                 Description = cr.Description,
                                 BrandName = b.BrandName,
                                 ColorName = cl.ColorName,
                                 DailyPrice = cr.DailyPrice,
                                 Status = !context.Rentals.Any(r => r.CarId == cr.Id && (r.ReturnDate == null || r.ReturnDate > DateTime.Now))
                             };
                return result.ToList();
            }
        }

        //public List<CarDetailDto> GetCarDetails()
        //{

        //        using (RentCarContext context = new RentCarContext())
        //        {
        //        var result = from c in context.Cars
        //                     join b in context.Brands
        //                     on c.BrandId equals b.Id
        //                     join co in context.Colors
        //                     on c.ColorId equals co.Id
        //                     select new CarDetailDto
        //                     {
        //                         Id = c.Id,
        //                         Description = c.Description,
        //                         BrandName = b.BrandName,
        //                         ColorName = co.ColorName,
        //                         DailyPrice = c.DailyPrice
        //                     };

        //        return result.ToList();
        //        }


        //}

        //public List<CarDetailDto> GetCarDetailsByBrand(int brandId)
        //{

        //    using (RentCarContext context = new RentCarContext())
        //    {
        //        var result = from c in context.Cars
        //                     join b in context.Brands
        //                     on c.BrandId equals b.Id
        //                     join co in context.Colors
        //                     on c.ColorId equals co.Id
        //                     where b.Id == brandId
        //                     select new CarDetailDto
        //                     {
        //                         Id = c.Id,
        //                         Description = c.Description,
        //                         BrandName = b.BrandName,
        //                         ColorName = co.ColorName,
        //                         DailyPrice = c.DailyPrice
        //                     };

        //        return result.ToList();
        //    }


        //}
    }
}
