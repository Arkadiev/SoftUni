using CarDealer.Data;
using CarDealer.DTOs.Export;
using CarDealer.DTOs.Import;
using CarDealer.Models;
using Castle.Core.Resource;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Globalization;

namespace CarDealer
{
    public class StartUp
    {
        public static void Main()
        {
            CarDealerContext context = new CarDealerContext();

            // 09 - Import Suppliers
            //string suppliersString = File.ReadAllText("../../../Datasets/suppliers.json");
            //Console.WriteLine(ImportSuppliers(context, suppliersString));

            // 10 - Import Parts
            //string partsString = File.ReadAllText("../../../Datasets/parts.json");
            //Console.WriteLine(ImportParts(context, partsString));

            // 11 - Import Cars
            //string carsString = File.ReadAllText("../../../Datasets/cars.json");
            //Console.WriteLine(ImportCars(context, carsString));

            // 12 - Import Customers
            //string customersString = File.ReadAllText("../../../Datasets/customers.json");
            //Console.WriteLine(ImportCustomers(context, customersString));

            // 13 - Import Sales
            //string salesString = File.ReadAllText("../../../Datasets/sales.json");
            //Console.WriteLine(ImportSales(context, salesString));

            // 14 - Export Ordered Customers
            //Console.WriteLine(GetOrderedCustomers(context));

            // 15 - Export Cars From Make Toyota
            //Console.WriteLine(GetCarsFromMakeToyota(context));

            // 16 - Export Local Suppliers
            //Console.WriteLine(GetLocalSuppliers(context));

            // 17 - Export Cars With Their List Of Parts
            //Console.WriteLine(GetCarsWithTheirListOfParts(context));

            // 18 - Export Total Sales By Customer
            //Console.WriteLine(GetTotalSalesByCustomer(context));

            // 19 - Export Sales With Applied Discount
            //Console.WriteLine(GetSalesWithAppliedDiscount(context));
        }

        // 09 - Import Suppliers
        public static string ImportSuppliers(CarDealerContext context, string inputJson)
        {
            var suppliers = JsonConvert.DeserializeObject<List<Supplier>>(inputJson);

            context.Suppliers.AddRange(suppliers);
            context.SaveChanges();

            return $"Successfully imported {suppliers.Count}.";
        }

        // 10 - Import Parts
        public static string ImportParts(CarDealerContext context, string inputJson)
        {
            var parts = JsonConvert.DeserializeObject<List<Part>>(inputJson);

            var validSupplierIds = context.Suppliers
                .Select(x => x.Id)
                .ToArray();

            var partsWithValidSupplierIds = parts
                .Where(p => validSupplierIds.Contains(p.SupplierId))
                .ToArray();

            context.Parts.AddRange(partsWithValidSupplierIds);
            context.SaveChanges();

            return $"Successfully imported {partsWithValidSupplierIds.Length}.";
        }

        // 11 - Import Cars
        public static string ImportCars(CarDealerContext context, string inputJson)
        {
            var carsDtos = JsonConvert.DeserializeObject<List<ImportCarDto>>(inputJson);

            var cars = new HashSet<Car>();
            var partsCars = new HashSet<PartCar>();

            foreach (var carDto in carsDtos)
            {
                var newCar = new Car()
                {
                    Make = carDto.Make,
                    Model = carDto.Model,
                    TraveledDistance = carDto.TraveledDistance
                };

                cars.Add(newCar);

                foreach (var partId in carDto.PartsId.Distinct())
                {
                    partsCars.Add(new PartCar()
                    {
                        Car = newCar,
                        PartId = partId
                    });
                }
            }

            context.Cars.AddRange(cars);
            context.PartsCars.AddRange(partsCars);
            context.SaveChanges();

            return $"Successfully imported {cars.Count}.";
        }

        // 12 - Import Customers
        public static string ImportCustomers(CarDealerContext context, string inputJson)
        {
            var customers = JsonConvert.DeserializeObject<List<Customer>>(inputJson);

            context.Customers.AddRange(customers);
            context.SaveChanges();

            return $"Successfully imported {customers.Count}.";
        }

        // 13 - Import Sales
        public static string ImportSales(CarDealerContext context, string inputJson)
        {
            var sales = JsonConvert.DeserializeObject<List<Sale>>(inputJson);

            context.Sales.AddRange(sales);
            context.SaveChanges();

            return $"Successfully imported {sales.Count}.";
        }

        // 14 - Export Ordered Customers
        public static string GetOrderedCustomers(CarDealerContext context)
        {
            var customers = context.Customers
                .OrderBy(c => c.BirthDate)
                .ThenBy(c => c.IsYoungDriver.Equals(0))
                .Select(c => new
                {
                    c.Name,
                    BirthDate = c.BirthDate.ToString("dd/MM/yyyy"),
                    c.IsYoungDriver
                })
                .ToArray();

            return JsonConvert.SerializeObject(customers, Formatting.Indented);
        }

        // 15 - Export Cars From Make Toyota
        public static string GetCarsFromMakeToyota(CarDealerContext context)
        {
            var cars = context.Cars
                .Where(c => c.Make == "Toyota")
                .OrderBy(c => c.Model)
                .ThenByDescending(c => c.TraveledDistance)
                .Select(c => new
                {
                    c.Id,
                    c.Make,
                    c.Model,
                    c.TraveledDistance
                })
            .ToArray();

            return JsonConvert.SerializeObject(cars, Formatting.Indented);
        }

        // 16 - Export Local Suppliers
        public static string GetLocalSuppliers(CarDealerContext context)
        {
            var suppliers = context.Suppliers
                .Where(s => s.IsImporter == false)
                .Select(s => new
                {
                    s.Id,
                    s.Name,
                    PartsCount = s.Parts.Count
                })
                .ToArray();

            return JsonConvert.SerializeObject(suppliers, Formatting.Indented);
        }

        // 17 - Export Cars With Their List Of Parts
        public static string GetCarsWithTheirListOfParts(CarDealerContext context)
        {
            var cars = context.Cars
                .Select(c => new
                {
                    car = new
                    {
                        c.Make,
                        c.Model,
                        c.TraveledDistance
                    },
                    parts = c.PartsCars
                    .Select(p => new
                    {
                        p.Part.Name,
                        Price = p.Part.Price.ToString("f2")
                    })
                })
                .ToArray();

            return JsonConvert.SerializeObject(cars, Formatting.Indented);
        }

        // 18 - Export Total Sales By Customer
        public static string GetTotalSalesByCustomer(CarDealerContext context)
        {
            var customers = context.Customers
                .Where(c => c.Sales.Count > 0)
                .Select(c => new CustomerTotalSalesDto()
                {
                    FullName = c.Name,
                    BoughtCars = c.Sales.Count,
                    SpentMoney = c.Sales.SelectMany(s => s.Car.PartsCars).Sum(pc => pc.Part.Price)
                })
                .OrderByDescending(c => c.SpentMoney)
                .ThenByDescending(c => c.BoughtCars)
                .ToArray();

            return JsonConvert.SerializeObject(customers, new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                ContractResolver = new DefaultContractResolver()
                {
                    NamingStrategy = new CamelCaseNamingStrategy()
                }
            });
        }

        // 19 - Export Sales With Applied Discount
        public static string GetSalesWithAppliedDiscount(CarDealerContext context)
        {
            var sales = context.Sales
                .Take(10)
                .Select(s => new
                {
                    car = new
                    {
                        s.Car.Make,
                        s.Car.Model,
                        s.Car.TraveledDistance
                    },
                    customerName = s.Customer.Name,
                    discount = s.Discount.ToString("f2"),
                    price = s.Car.PartsCars.Sum(pc => pc.Part.Price).ToString("f2"),
                    priceWithDiscount = (s.Car.PartsCars.Sum(pc => pc.Part.Price) * (1 - s.Discount / 100)).ToString("f2")
                })
                .ToArray();

            return JsonConvert.SerializeObject(sales, Formatting.Indented);
        }
    }
}