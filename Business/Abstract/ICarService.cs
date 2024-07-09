using System;
using Core.Utilities.Results;
using Entities;
using Entities.DTOs;

namespace Business.Abstract
{
	public interface ICarService
	{
		IDataResult<List<Car>> GetAll();
		IDataResult<Car> GetById(int id);
        IDataResult<List<Car>> GetAllByBrandId(int brandId);
		IDataResult<List<CarDetailDto>> GetCarDetails();
		IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
	}
}

