using Business.Abstract;
using Business.Concrete;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

internal class Program
{
    private static void Main(string[] args)
    {
        //CarTest();
        //BrandTest();
        //ColorTest();
        //CustomerTest();
        //UserTest();
        RentalTest();
    }

    private static void CarTest()
    {
        ICarService carService = new CarManager(new EfCarDal());

        Console.WriteLine("There are currently {0} cars available for rent.", carService.GetAll().Data.Count());

        foreach (var car in carService.GetCarDetails().Data)
        {
            Console.WriteLine("{0} --- {1} --- {2} --- {3}", car.CarID, car.Description, car.BrandName, car.ColorName);
        }

        Console.WriteLine("------------------------------");

        foreach (var car in carService.GetAllByBrandId(1).Data)
        {
            Console.WriteLine("{0} - {1}", car.CarId, car.Description);
        }

        Console.WriteLine(carService.GetById(3).Data.Description);
    }
    private static void BrandTest()
    {
        IBrandService brandService = new BrandManager(new EfBrandDal());

        Console.WriteLine("There are currently {0} brands available for rent.", brandService.GetAll().Data.Count());

        Console.WriteLine("------------------------------");

        foreach (var brand in brandService.GetAll().Data)
        {
            Console.WriteLine("Brand id: {0} , Brand Name: {1}", brand.BrandId, brand.BrandName);
        }

        Brand brand2 = brandService.GetById(2).Data;

        Console.WriteLine("{0} - {1}", brand2.BrandId, brand2.BrandName);

    }
    private static void ColorTest()
    {
        IColorService colorService = new ColorManager(new EfColorDal());

        Console.WriteLine("There are currently {0} colors.", colorService.GetAll().Data.Count());

        Console.WriteLine("------------------------------");

        foreach (var color in colorService.GetAll().Data)
        {
            Console.WriteLine("Color id: {0} , Color Name: {1}", color.ColorId, color.ColorName);
        }

        Console.WriteLine("--------Get By Id---------");

        Color color2 = colorService.GetById(2).Data;

        Console.WriteLine("Color id: {0} - Color name: {1}", color2.ColorId, color2.ColorName);

        // add function tested and it is working.
        //Console.WriteLine("--------Add---------");

        //Color newColor = new Color();
        //newColor.ColorName = "Green";
        //newColor.ColorId = 4;

        //colorService.Add(newColor);
    }
    private static void CustomerTest()
    {
        ICustomerService customerService = new CustomerManager(new EfCustomerDal());

        Console.WriteLine("There are currently {0} customers available.", customerService.GetAll().Data.Count());

        Console.WriteLine("------------------------------");

        // add function tested and it is working.
        //Customer newCustomer = new Customer();
        //newCustomer.CustomerId = 2;
        //newCustomer.UserId = 2;
        //newCustomer.CompanyName = "test2 company";
        //customerService.Add(newCustomer);

        Console.WriteLine("------------------------------");

        foreach (var customer in customerService.GetAll().Data)
        {
            Console.WriteLine("Customer id: {0} , Customer Company Name: {1}", customer.CustomerId, customer.CompanyName);
        }

        Console.WriteLine("---------By id---------");

        Customer customer2 = customerService.GetById(1).Data;

        Console.WriteLine("Customer Id: {0} , Company Name: {1}", customer2.CustomerId, customer2.CompanyName);

    }
    private static void RentalTest()
    {
        IRentalService rentalService = new RentalManager(new EfRentalDal());

        Console.WriteLine("There are currently {0} rentals available.", rentalService.GetAll().Data.Count());

        Console.WriteLine("------------------------------");


        // add function tested and it is working.
        Rental newRental = new Rental();
        newRental.RentalId = 6;
        newRental.CarId = 3;
        newRental.CustomerId = 2;
        newRental.RentDate = DateTime.Now;
        //newRental.ReturnDate = DateTime.Now;
        IResult result = rentalService.Add(newRental);
        Console.WriteLine(result.Message);

        Console.WriteLine("------------------------------");

        Console.WriteLine(rentalService.GetAll().Message);

        Console.WriteLine("------------------------------");

        foreach (var rental in rentalService.GetAll().Data)
        {
            Console.WriteLine("Rental id: {0} , Customer id: {1} , Rent date: {2} , Return date: {3}",
                rental.RentalId, rental.CustomerId, rental.RentDate, rental.ReturnDate);
        }

        Console.WriteLine("---------By id---------");

        Rental rental2 = rentalService.GetById(1).Data;

        Console.WriteLine("Rental id: {0} , Customer id: {1} , Rent date: {2} , Return date: {3}",
                rental2.RentalId, rental2.CustomerId, rental2.RentDate, rental2.ReturnDate);

    }
    private static void UserTest()
    {
        IUserService userService = new UserManager(new EfUserDal());

        Console.WriteLine("There are currently {0} users available.", userService.GetAll().Data.Count());

        Console.WriteLine("------------------------------");

        // add function tested and it is working.
        //User newUser = new User();
        //newUser.UserId = 2;
        //newUser.FirstName = "Bekir";
        //newUser.LastName = "Arslan";
        //newUser.Email = "bekir@mail.com";
        //newUser.Password = "password";
        //userService.Add(newUser);

        Console.WriteLine("------------------------------");

        foreach (var user in userService.GetAll().Data)
        {
            Console.WriteLine("User id: {0} , User First Name: {1} , User Last Name: {2} , User Email: {3}",
                user.UserId, user.FirstName, user.LastName, user.Email);
        }

        Console.WriteLine("---------By id---------");

        User user2 = userService.GetById(1).Data;

        Console.WriteLine("User id: {0} , User First Name: {1} , User Last Name: {2} , User Email: {3}",
                user2.UserId, user2.FirstName, user2.LastName, user2.Email);

    }
}