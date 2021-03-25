using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        //List<CarDetailDto> GetCarDetails();
        //List<CarDetailDto> GetCarDetailsByBrand(int brandId);

        List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null);
    }
}
