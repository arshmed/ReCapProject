using System;
using Core.DataAccess;
using Entities;
using Entities.DTOs;

namespace DataAccess.Abstract
{
	public interface ICarDal : IEntityRepository<Car>
	{
        List<CarDetailDto> GetCarDetails();

    }
}

