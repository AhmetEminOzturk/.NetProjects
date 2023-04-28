using Api.DataAccessLayer.Abstract;
using Api.DataAccessLayer.Concrete;
using Api.DataAccessLayer.Repositories;
using Api.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.DataAccessLayer.EntityFramework
{
    public class EfCustomerDal : GenericRepository<Customer>, ICustomerDal
    {
        public int GetCustomerCount()
        {
            var context = new Context();
            return context.Customers.Count();
        }
    }
}
