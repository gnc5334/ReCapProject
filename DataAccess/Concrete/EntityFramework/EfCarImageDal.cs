
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarImageDal : EfEntityRepositoryBase<CarImage, RentCarContext>,ICarImageDal
    {
        public bool IsExist(int id)
        {
            using (RentCarContext context = new RentCarContext())
            {
                return context.CarImages.Any(p => p.Id == id);
            }
        }
    }
}
