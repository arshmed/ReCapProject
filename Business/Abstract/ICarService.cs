using System;
using Entities;
using Entities.DTOs;

namespace Business.Abstract
{
	public interface ICarService
	{
		List<Car> GetAll();
		Car GetById(int id);
		List<Car> GetAllByBrandId(int brandId);
		List<CarDetailDto> GetCarDetails();
		void Add(Car car);
		void Delete(Car car);
		void Update(Car car);
	}
}

