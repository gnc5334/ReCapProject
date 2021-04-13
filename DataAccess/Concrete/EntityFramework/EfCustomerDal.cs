using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal:EfEntityRepositoryBase<Customer, RentCarContext>, ICustomerDal
    {

        public List<CustomerDetailDto> GetCustomerDetails(Expression<Func<Customer, bool>> filter = null)
        {
            using (RentCarContext context = new RentCarContext())
            {
                var result = from ct in filter == null ? context.Customers : context.Customers.Where(filter)
                             join us in context.Users
                                 on ct.UserId equals us.Id
                             select new CustomerDetailDto
                             {
                                 CustomerId = ct.CustomerId,
                                 UserId = us.Id,
                                 CompanyName = ct.CompanyName,
                                 Email = us.Email,
                                 FirstName = us.FirstName,
                                 LastName = us.LastName,
                                 Status = us.Status,
                                 PhoneNumber = ct.PhoneNumber,
                                 Address = ct.Address,
                                 FindeksScore = ct.FindeksScore
                             };
                return result.ToList();

            }
        }
    }
}
