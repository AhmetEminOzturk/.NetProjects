using Api.DataAccessLayer.Abstract;
using Api.DataAccessLayer.Repositories;
using Api.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.DataAccessLayer.EntityFramework
{
    public class EfBalanceDal:GenericRepository<Balance>, IBalanceDal
    {
    }
}
