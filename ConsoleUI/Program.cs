using Business.Concrete;
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
            List<Colors> _colors = new List<Colors>
            {
                new Colors{ Id=1, ColorName="Red"},
                new Colors{ Id=2, ColorName="Bej"},
                new Colors{ Id=3, ColorName="Mavi"},
                new Colors{ Id=4, ColorName="Beyaz"},
                new Colors{ Id=5, ColorName="Siyah"}
            };

            List<Brand> _brands = new List<Brand>
            {
                new Brand{ Id=1, BrandName="Toyota"},
                new Brand{ Id=2, BrandName="Renault"},
                new Brand{ Id=3, BrandName="Opel"},
                new Brand{ Id=4, BrandName="BMW"},
                new Brand{ Id=5, BrandName="Honda"},
                new Brand{ Id=6, BrandName="Nissan"},
                new Brand{ Id=7, BrandName="Peugeot"}

            };

            CarManager carManager = new CarManager(new InMemoryCarDal());

            Console.WriteLine(" ******** KİRALIK ARAÇ FİYATLARI  ******** \n");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("{0} -- Günlük Fiyat: {1} TL",car.Description,car.DailyPrice);
            }

            Console.Read();
        }
    }
}
