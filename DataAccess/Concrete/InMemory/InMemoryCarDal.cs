using System;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {

        List<Car> _cars = new List<Car>
        {
            new Car{CarId=1, BrandId=1, ColorId=1, DailyPrice=200, Description="BMW", ModelYear=2012},
            new Car{CarId=2, BrandId=2, ColorId=3, DailyPrice=300, Description="Audi", ModelYear=2014},
            new Car{CarId=3, BrandId=3, ColorId=2, DailyPrice=150, Description="GMC", ModelYear=2019},
            new Car{CarId=4, BrandId=1, ColorId=4, DailyPrice=400, Description="BMW", ModelYear=2022}
        };

        public void Add(Car car)
        {
            _cars.Add(car);
            Console.WriteLine("Car added.");
        }

        public void Delete(int carId)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == carId);
            _cars.Remove(carToDelete);

            Console.WriteLine("Car deleted.");
        }

        public void Delete(Car entity)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int carId)
        {
            return _cars.SingleOrDefault(c => c.CarId == carId);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

        }
    }
}

