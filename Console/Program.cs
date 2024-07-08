using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

internal class Program
{
    private static void Main(string[] args)
    {
        //CarTest();
        //BrandTest();
        ColorTest();
    }

    private static void CarTest()
    {
        ICarService carService = new CarManager(new EfCarDal());

        Console.WriteLine("There are currently {0} cars available for rent.", carService.GetAll().Count());

        foreach (var car in carService.GetCarDetails())
        {
            Console.WriteLine("{0} --- {1} --- {2} --- {3}", car.CarID, car.Description, car.BrandName, car.ColorName);
        }

        Console.WriteLine("------------------------------");

        foreach (var car in carService.GetAllByBrandId(1))
        {
            Console.WriteLine("{0} - {1}", car.CarId, car.Description);
        }

        Console.WriteLine(carService.GetById(3).Description);
    }
    private static void BrandTest()
    {
        IBrandService brandService = new BrandManager(new EfBrandDal());

        Console.WriteLine("There are currently {0} brands available for rent.", brandService.GetAll().Count());

        Console.WriteLine("------------------------------");

        foreach (var brand in brandService.GetAll())
        {
            Console.WriteLine("Brand id: {0} , Brand Name: {1}", brand.BrandId, brand.BrandName);
        }

        Brand brand2 = brandService.GetById(2);

        Console.WriteLine("{0} - {1}", brand2.BrandId, brand2.BrandName);

    }
    private static void ColorTest()
    {
        IColorService colorService = new ColorManager(new EfColorDal());

        Console.WriteLine("There are currently {0} colors.", colorService.GetAll().Count());

        Console.WriteLine("------------------------------");

        foreach (var color in colorService.GetAll())
        {
            Console.WriteLine("Color id: {0} , Color Name: {1}", color.ColorId, color.ColorName);
        }

        Console.WriteLine("--------Get By Id---------");

        Color color2 = colorService.GetById(2);

        Console.WriteLine("Color id: {0} - Color name: {1}", color2.ColorId, color2.ColorName);

        // add function testes and it is working.
        //Console.WriteLine("--------Add---------");

        //Color newColor = new Color();
        //newColor.ColorName = "Green";
        //newColor.ColorId = 4;

        //colorService.Add(newColor);
;    }
}