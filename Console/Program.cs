using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

internal class Program
{
    private static void Main(string[] args)
    {

        ICarService carService = new CarManager(new EfCarDal());

        Console.WriteLine("There are currently {0} cars available for rent.", carService.GetAll().Count());

        foreach (var car in carService.GetAll())
        {
            Console.WriteLine("{0} --> {1}", car.Description, car.ModelYear);
        }
    
    }
}