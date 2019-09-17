using DataAccess;
using Decorator.Component;
using Decorator.ConcreteComponents;
using Decorator.ConcreteDecorators;
using Facade.TemperatureFacade;
using Factory.SimpleFactory.Autos;
using Factory.SimpleFactory.Factories;
using Repository.Repositories;
using Strategy;
using Strategy.Model;
using Strategy.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork;

namespace DesignPatternMain
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //executeDecorator();
            //executeFacade();
            //executeStrategy();
            //executeSimpleFactory();
            //executeAbstractFactory();
            //executeRepository();
            executeUnitOfWork();
        }

        static void executeDecorator()
        {
            Pizza largePizza = new LargePizza();
            largePizza = new Cheese(largePizza);
            largePizza = new Ham(largePizza);
            largePizza = new Pepper(largePizza);

            Console.WriteLine(largePizza.GetDescription());
            Console.WriteLine("{0:C2}", largePizza.CalculateCost());

            Console.ReadKey();
        }

        static void executeStrategy()
        {
            var strategy = new FedExShippingCostStrategy();
            ShippingCostCalculatorService shippingCostCalculatorService = new ShippingCostCalculatorService(strategy);
            var order = new Order()
            {
                ShippingMethod = "FedEx",
                Destination = "1234 Desmesa St. Makati City philippines",
                Origin = "123 Linoln St. America"
            };

            var cost = shippingCostCalculatorService.CalculateShippingCost(order);

            Console.WriteLine("Shipping Method: " + order.ShippingMethod);
            Console.WriteLine("Destination: " + order.Destination);
            Console.WriteLine("Origin: " + order.Origin);

            Console.WriteLine("Cost: " + cost);
            Console.ReadKey();
        }

        static void executeFacade()
        {
            const string zipCode = "83714";

            var temperatureFacade = new TemperatureLookupFacade();
            LocalTemperature localTemp = temperatureFacade.GetTemperature(zipCode);

            Console.WriteLine("The current temperature is {0}F/{1}C. in {2}, {3}",
                                localTemp.Farenheit.ToString("F1"),
                                localTemp.Celcius.ToString("F1"),
                                localTemp.City,
                                localTemp.State);

            Console.ReadKey();
        }

        static void executeSimpleFactory()
        {
            IAutoFactory autoFactory = new BMWFactory();

            IAuto car = autoFactory.CreateAutomobile();

            car.TurnOn();
            car.TurnOff();
            Console.ReadKey();
        }

        static void executeAbstractFactory()
        {
            AbstractFactory.Factory.IAutoFactory factory = new AbstractFactory.Factory.BMWFactory();

            Console.WriteLine();
            Console.WriteLine("++++++++++++++++ {0} ++++++++++++++++++", "SPORTS CAR");

            var car = factory.CreateSportsCar();
            car.TurnOn();
            car.TurnOff();

            Console.WriteLine();
            Console.WriteLine("++++++++++++++++ {0} ++++++++++++++++++", "LUXURY CAR");
            car.TurnOn();
            car.TurnOff();

            Console.WriteLine();
            Console.WriteLine("++++++++++++++++ {0} ++++++++++++++++++", "ECONOMY CAR");
            car.TurnOn();
            car.TurnOff();

            Console.ReadKey();
        }

        static void executeRepository()
        {

            using (DesignPatternDBEntities entities = new DesignPatternDBEntities())
            {
                CustomerRepository customerRepository = new CustomerRepository(entities);
                var x = customerRepository.FindById(1);

                Console.WriteLine("Customer First Name: " + x.FirstName);
                Console.WriteLine("Customer Middle Name: " + x.MiddleName);
                Console.ReadKey();
            }
                
        }

        static void executeUnitOfWork()
        {
            using (DesignPatternDBEntities entities = new DesignPatternDBEntities())
            {
                UnitOfWork.UnitOfWork UoW = new UnitOfWork.UnitOfWork(entities);

                Customer customer = new Customer();
                Address address = new Address();
                Random rnd = new Random();
                int rngNum = rnd.Next(1, 500);

                customer.FirstName = "FirstName " + rngNum;
                customer.MiddleName = "MiddleName " + rngNum;
                customer.LastName = "LastName " + rngNum;

                rngNum = rnd.Next(1, 500);
                address.City = "City Number " + rngNum ;
                address.StreetAddress = rngNum + " Street";

                rngNum = rnd.Next(1000, 9999);
                address.ZipCode = rngNum.ToString();
                address.State = "QW " + rngNum;
                address.CustomerId = customer.CustomerId;

                UoW.CustomerRepo.Add(customer);

                UoW.AddressRepo.Add(address);

                UoW.Commit();

                var displayCustomer = UoW.CustomerRepo.FindById(customer.CustomerId);
                var displayAddress = UoW.AddressRepo.FindById(address.Id);

                Console.WriteLine("Newly Created Customer: " + "ID: " + displayCustomer.CustomerId + ", Name: " + displayCustomer.FirstName 
                                + " " + displayCustomer.MiddleName + ", " + displayCustomer.LastName);

                Console.WriteLine("Newly Created Address: " + "ID: " + displayAddress.Id);
                Console.WriteLine("City: " + displayAddress.City);
                Console.WriteLine("Street Address: " + displayAddress.StreetAddress);
                Console.WriteLine("ZipCode: " + displayAddress.ZipCode);
                Console.WriteLine("State: " + displayAddress.State);

                Console.ReadKey();

            }
        }

    }
}
