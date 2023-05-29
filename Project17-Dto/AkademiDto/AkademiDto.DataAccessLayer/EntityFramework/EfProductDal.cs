using AkademiDto.DataAccessLayer.Abstract;
using AkademiDto.DataAccessLayer.Repositories;
using AkademiDto.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiDto.DataAccessLayer.EntityFramework
{
    public class EfProductDal:GenericRepository<Product>,IProductDal
    {
    }
}
