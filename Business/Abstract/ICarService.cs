using System;
using Entities;

namespace Business.Abstract
{
	public interface ICarService
	{
		List<Car> GetAll();
		void Add(Car car);
	}
}

