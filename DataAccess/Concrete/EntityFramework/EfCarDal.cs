using System;
using System.Linq.Expressions;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, DatabaseContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using(DatabaseContext context = new DatabaseContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.BrandId
                             join cl in context.Colors on c.ColorId equals cl.ColorId
                             orderby c.Description
                             select new CarDetailDto { CarID=c.CarId, Description=c.Description,
                             BrandName=b.BrandName,ColorName=cl.ColorName};
                return result.ToList();
            }
        }
    }
}

