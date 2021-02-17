using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ColorCRUDMethod();
            //BrandCRUDMethod();
            //CarCRUDMethod();

            Console.WriteLine("***********Araç Kiralama Sistemi***********\n");


            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.Rental(new Rental
            {
                CarId = 1,
                CustomerId = 1,
                RentDate = new DateTime(2021, 1, 14),
                ReturnDate = new DateTime(2021, 2, 07)
            });
            Console.WriteLine(result.Message);

            Console.Read();
        }



        private static void CarCRUDMethod()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            //carManager.Add(new Car { BrandId = 8, ColorId = 2, DailyPrice = 120, ModelYear = 2015, Description = "Audi" });
            carManager.Update(new Car { Id = 3, BrandId = 3, ColorId = 6, DailyPrice = 180, ModelYear = 2020, Description = "Opel Insignia, Otomatik" });
            var result = carManager.GetById(3);
            if (result.Success)
            {
                Console.WriteLine("\n Güncellenen araba : {0} \n\n ", result.Data.Description);
            }
            

            Console.WriteLine(" ******* KİRALIK ARAÇLAR ******* \n");
            var listResult = carManager.GetCarDetails();
            if (listResult.Success)
            {
                foreach (var car in listResult.Data)
                {
                    Console.WriteLine("{0} \n Marka : {1} \n Renk : {2} \n Günlük Fiyat : {3} \n",
                                       car.Description, car.BrandName, car.ColorName, car.DailyPrice.ToString("N2"));
                }
            }
            
        }

        private static void BrandCRUDMethod()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand { Id = 8, BrandName = "Audi" });
            brandManager.Add(new Brand { Id = 9, BrandName = "Jaguar" });
            brandManager.Add(new Brand { Id = 10, BrandName = "Volkswagen" });
            brandManager.Update(new Brand { Id = 6, BrandName = "Skoda" });
            brandManager.Delete(new Brand { Id=10 });
        }

        private static void ColorCRUDMethod()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color { Id = 6, ColorName = "Gri" });
            colorManager.Update(new Color { Id = 2, ColorName = "Petrol Yeşili" });
        }

    }
}
