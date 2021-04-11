﻿using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        { 
            _cars = new List<Car> 
            { 
               new Car{ Id=1, BrandId=2, ColorId=1, DailyPrice=200, ModelYear=2010, Description="RENAULT CLIO AT 1.5, Otomatik"},
               new Car{ Id=2, BrandId=4, ColorId=2, DailyPrice=300, ModelYear=2015, Description="BMW 320i, Otomatik"},
               new Car{ Id=3, BrandId=3, ColorId=4, DailyPrice=150, ModelYear=2020, Description="Opel Insignia, Otomatik"},
               new Car{ Id=4, BrandId=7, ColorId=3, DailyPrice=300, ModelYear=2008, Description="Peugeot 5008, Otomatik"},
               new Car{ Id=5, BrandId=1, ColorId=5, DailyPrice=250, ModelYear=2019, Description="Toyota Corolla 1.6 Vision, Yarı Otomatik "}

            };

        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c=>c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;        
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id == car.Id);
            _cars.Remove(carToDelete);

        }

        //public List<Car> GetAll()
        //{
        //    return _cars;
        //}

        //public List<Car> GetById(int carId)
        //{
        //    return _cars.Where(c=>c.Id == carId).ToList();
        //}

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetailsByBrand(int brandId)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetDetailsByCarId(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }
    }
}
