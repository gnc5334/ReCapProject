using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentCarContext>, ICarDal
    {

        public List<CarDetailDto> GetDetailsByCarId(Expression<Func<Car, bool>> filter = null)
        {

            using (RentCarContext context = new RentCarContext())
            {

                var result = from cr in filter == null ? context.Cars : context.Cars.Where(filter)
                             join b in context.Brands on cr.BrandId equals b.Id
                             join cl in context.Colors on cr.ColorId equals cl.Id
                             select new CarDetailDto
                             {
                                 Id = cr.Id,
                                 ModelYear = cr.ModelYear,
                                 Description = cr.Description,
                                 BrandName = b.BrandName,
                                 ColorName = cl.ColorName,
                                 DailyPrice = cr.DailyPrice,
                                 ABS = cr.ABS,
                                 Fuel = cr.Fuel,
                                 Gear = cr.Gear,
                                 ParkingSensor = cr.ParkingSensor,
                                 MinFindeksScore = cr.MinFindeksScore,
                                 Status = !context.Rentals.Any(r => r.CarId == cr.Id && (r.ReturnDate == null || r.ReturnDate > DateTime.Now))
                             };
                return result.ToList();
            }


        }

        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            using (RentCarContext context = new RentCarContext())
            {
                var result = from cr in filter == null ? context.Cars : context.Cars.Where(filter)
                             join b in context.Brands on cr.BrandId equals b.Id
                             join cl in context.Colors on cr.ColorId equals cl.Id
                             select new CarDetailDto
                             {
                                 Id = cr.Id,
                                 ModelYear = cr.ModelYear,
                                 Description = cr.Description,
                                 BrandName = b.BrandName,
                                 ColorName = cl.ColorName,
                                 DailyPrice = cr.DailyPrice,
                                 ABS = cr.ABS,
                                 Fuel = cr.Fuel,
                                 Gear = cr.Gear,
                                 ParkingSensor = cr.ParkingSensor,
                                 MinFindeksScore = cr.MinFindeksScore,
                                 Status = !context.Rentals.Any(r => r.CarId == cr.Id && (r.ReturnDate == null || r.ReturnDate > DateTime.Now))
                             };
                return result.ToList();
            }
        }


    }
}
