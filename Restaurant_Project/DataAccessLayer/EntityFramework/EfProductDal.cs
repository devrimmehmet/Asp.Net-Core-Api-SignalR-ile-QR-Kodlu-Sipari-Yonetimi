using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using DtoLayer.ProductDto;
using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        private  readonly RestaurantDbContext _dbContext;
        public EfProductDal(RestaurantDbContext dbContext) : base(dbContext)
        {
            _dbContext=dbContext;
        }

        public List<Product> GetProductWithCategories()
        {
            var values = (_dbContext?.Products?.Include(x => x.Category).ToList())!;
            return values;

        }
    }
}
