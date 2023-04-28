using Api.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.DataAccessLayer.Abstract
{
    public interface ICustomerDal:IGenericDal<Customer>
    {
        int GetCustomerCount();
    }
}
