using CarDealer.Data;
using CarDealer.DTOs.Export;
using CarDealer.DTOs.Import;
using CarDealer.Models;
using Castle.Core.Resource;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace CarDealer
{
    public class StartUp
    {
        public static void Main()
        {
            CarDealerContext context = new CarDealerContext();

            // 09 - Import Suppliers
            //string suppliersXml = File.ReadAllText("../../../Datasets/suppliers.xml");
            //Console.WriteLine(ImportSuppliers(context, suppliersXml));

            // 10 - Import Parts
            //string partsXml = File.ReadAllText("../../../Datasets/parts.xml");
            //Console.WriteLine(ImportSuppliers(context, partsXml));

            // 11 - Import Cars
            //string carsXml = File.ReadAllText("../../../Datasets/cars.xml");
            //Console.WriteLine(ImportCars(context, carsXml));

            // 12 - Import Customers
            //string customersXml = File.ReadAllText("../../../Datasets/customers.xml");
            //Console.WriteLine(ImportCustomers(context, customersXml));

            // 13 - Import Sales
            //string salesXml = File.ReadAllText("../../../Datasets/sales.xml");
            //Console.WriteLine(ImportSales(context, salesXml));

            // 14 - Export Cars With Distance
            //Console.WriteLine(GetCarsWithDistance(context));

            // 15 - Export Cars From Make BMW
            //Console.WriteLine(GetCarsFromMakeBmw(context));

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
        public static string ImportSuppliers(CarDealerContext context, string inputXml)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(SupplierImportDto[]), new XmlRootAttribute("Suppliers"));

            SupplierImportDto[] suppliersDto;
            using (var reader = new StringReader(inputXml))
            {
                suppliersDto = (SupplierImportDto[])xmlSerializer.Deserialize(reader);
            };

            Supplier[] suppliers = suppliersDto
                .Select(dto => new Supplier()
                {
                    Name = dto.Name,
                    IsImporter = dto.IsImporter
                })
                .ToArray();

            context.Suppliers.AddRange(suppliers);
            context.SaveChanges();

            return $"Successfully imported {suppliers.Length}";
        }

        // 10 - Import Parts
        public static string ImportParts(CarDealerContext context, string inputXml)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(PartsImportDto[]), new XmlRootAttribute("Parts"));

            PartsImportDto[] partsImportDto;
            using (var reader = new StringReader(inputXml))
            {
                partsImportDto = (PartsImportDto[])xmlSerializer.Deserialize(reader);
            }

            var supplierIds = context.Suppliers
                .Select(s => s.Id)
                .ToArray();

            var partsWithValidSuppliers = partsImportDto
                .Where(p => supplierIds.Contains(p.SupplierId))
                .ToArray();

            Part[] parts = partsWithValidSuppliers
                .Select(dto => new Part()
                {
                    Name = dto.Name,
                    Price = dto.Price,
                    Quantity = dto.Quantity,
                    SupplierId = dto.SupplierId
                })
                .ToArray();

            context.Parts.AddRange(parts);
            context.SaveChanges();

            return $"Successfully imported {parts.Length}";
        }

        // 11 - Import Cars
        public static string ImportCars(CarDealerContext context, string inputXml)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(CarImportDto[]), new XmlRootAttribute("Cars"));

            CarImportDto[] carImportDtos;
            using (var reader = new StringReader(inputXml))
            {
                carImportDtos = (CarImportDto[])xmlSerializer.Deserialize(reader);
            }

            List<Car> cars = new List<Car>();

            foreach (var dto in carImportDtos)
            {
                Car car = new Car()
                {
                    Make = dto.Make,
                    Model = dto.Model,
                    TraveledDistance = dto.TraveledDistance
                };

                int[] carPartIds = dto.PartIds
                    .Select(p => p.Id)
                    .Distinct()
                    .ToArray();

                var carParts = new List<PartCar>();

                foreach (var id in carPartIds)
                {
                    carParts.Add(new PartCar()
                    {
                        Car = car,
                        PartId = id
                    });
                }

                car.PartsCars = carParts;
                cars.Add(car);
            }

            context.AddRange(cars);
            context.SaveChanges();

            return $"Successfully imported {cars.Count}";
        }

        // 12 - Import Customers
        public static string ImportCustomers(CarDealerContext context, string inputXml)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(CustomerImportDto[]), new XmlRootAttribute("Customers"));

            CustomerImportDto[] customerImportDtos;
            using (var reader = new StringReader(inputXml))
            {
                customerImportDtos = (CustomerImportDto[])xmlSerializer.Deserialize(reader);
            }

            Customer[] customers = customerImportDtos
                .Select(dto => new Customer()
                {
                    Name = dto.Name,
                    BirthDate = dto.BirthDate,
                    IsYoungDriver = dto.IsYoungDriver
                })
                .ToArray();

            context.Customers.AddRange(customers);
            context.SaveChanges();

            return $"Successfully imported {customers.Length}";
        }

        // 13 - Import Sales
        public static string ImportSales(CarDealerContext context, string inputXml)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(SalesImportDto[]), new XmlRootAttribute("Sales"));

            using StringReader reader = new StringReader(inputXml);

            SalesImportDto[] salesImportDtos = (SalesImportDto[])xmlSerializer.Deserialize(reader);

            int[] carIds = context.Cars
                .Select(x => x.Id)
                .ToArray();

            var validSalesImport = salesImportDtos
                .Where(dto => carIds.Contains(dto.CarId))
                .ToArray();

            Sale[] sales = validSalesImport
                .Select(vs => new Sale()
                {
                    CarId = vs.CarId,
                    CustomerId = vs.CustomerId,
                    Discount = vs.Discount
                })
                .ToArray();

            context.Sales.AddRange(sales);
            context.SaveChanges();

            return $"Successfully imported {sales.Length}";
        }

        // 14 - Export Cars With Distance
        public static string GetCarsWithDistance(CarDealerContext context)
        {
            var carsWithDistance = context.Cars
                .Select(c => new CarWithDistanceExportDto()
                {
                    Make = c.Make,
                    Model = c.Model,
                    TraveledDistance = c.TraveledDistance
                })
                .OrderBy(c => c.Make)
                .ThenBy(c => c.Model)
                .Take(10)
                .ToArray();

            return SerializeToXml(carsWithDistance, "cars");
        }

        // 15 - Export Cars From Make BMW
        public static string GetCarsFromMakeBmw(CarDealerContext context)
        {
            var bmws = context.Cars
                .Where(c => c.Make == "BMW")
                .Select(c => new BmwExportDto()
                {
                    Id = c.Id,
                    Model = c.Model,
                    TraveledDistance = c.TraveledDistance
                })
                .OrderBy(c => c.Model)
                .ThenByDescending(c => c.TraveledDistance)
                .ToArray();

            return SerializeToXml(bmws, "cars", true);
        }

        // 16 - Export Local Suppliers
        public static string GetLocalSuppliers(CarDealerContext context)
        {
            var localSuppliers = context.Suppliers
                .Where(s => s.IsImporter == false)
                .Select(s => new LocalSupplierExportDto()
                {
                    Id = s.Id,
                    Name = s.Name,
                    PartsCount = s.Parts.Count
                })
                .ToArray();

            return SerializeToXml(localSuppliers, "suppliers", true);
        }

        // 17 - Export Cars With Their List Of Parts
        public static string GetCarsWithTheirListOfParts(CarDealerContext context)
        {
            var carsWithParts = context.Cars
                .OrderByDescending(c => c.TraveledDistance)
                .ThenBy(c => c.Model)
                .Take(5)
                .Select(c => new CarWithParts()
                {
                    Make = c.Make,
                    Model = c.Model,
                    TraveledDistance = c.TraveledDistance,
                    Parts = c.PartsCars
                        .OrderByDescending(p => p.Part.Price)
                        .Select(p => new PartsForCarsDto()
                        {
                            Name = p.Part.Name,
                            Price = p.Part.Price
                        })
                        .ToArray()
                })
                .ToArray();

            return SerializeToXml(carsWithParts, "cars");
        }

        // 18 - Export Total Sales By Customer
        public static string GetTotalSalesByCustomer(CarDealerContext context)
        {
            var temp = context.Customers
                .Where(c => c.Sales.Any())
                .Select(c => new
                {
                    FullName = c.Name,
                    BoughtCars = c.Sales.Count,
                    SalesInfo = c.Sales.Select(s => new
                    {
                        Prices = c.IsYoungDriver
                        ? s.Car.PartsCars.Sum(pc => Math.Round((double)pc.Part.Price * 0.95, 2))
                        : s.Car.PartsCars.Sum(pc => (double)pc.Part.Price)
                    })
                    .ToArray()
                })
                .ToArray();

            var customerSalesInfo = temp
                .OrderByDescending(x => x.SalesInfo.Sum(y => y.Prices))
                .Select(a => new CustomerExportDto()
                {
                    FullName = a.FullName,
                    CarsBought = a.BoughtCars,
                    MoneySpent = a.SalesInfo.Sum(b => (decimal)b.Prices)
                })
                .ToArray();

            return SerializeToXml(customerSalesInfo, "customers");
        }

        // 19 - Export Sales With Applied Discount
        public static string GetSalesWithAppliedDiscount(CarDealerContext context)
        {
            var sales = context.Sales
                .Select(s => new SaleWithDiscount()
                {
                    Car = new CarDto
                    {
                        Make = s.Car.Make,
                        Model = s.Car.Model,
                        TraveledDistance = s.Car.TraveledDistance
                    },
                    Discount = s.Discount,
                    CustomerName = s.Customer.Name,
                    Price = s.Car.PartsCars.Sum(c => c.Part.Price),
                    PriceWithDiscount = Math.Round(s.Car.PartsCars.Sum(c => (double)(c.Part.Price)) * (double)(1 - s.Discount / 100), 4)
                })
                .ToArray();

            return SerializeToXml(sales, "sales");
        }

        private static string SerializeToXml<T>(T dto, string xmlRootAttribute, bool omitDeclaration = false)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T), new XmlRootAttribute(xmlRootAttribute));
            StringBuilder stringBuilder = new StringBuilder();

            XmlWriterSettings settings = new XmlWriterSettings
            {
                OmitXmlDeclaration = omitDeclaration,
                Encoding = new UTF8Encoding(false),
                Indent = true

            };

            using (StringWriter stringWriter = new StringWriter(stringBuilder, CultureInfo.InvariantCulture))
            using (XmlWriter xmlWriter = XmlWriter.Create(stringWriter, settings))
            {
                XmlSerializerNamespaces xmlSerializerNamespaces = new XmlSerializerNamespaces();
                xmlSerializerNamespaces.Add(string.Empty, string.Empty);

                try
                {
                    xmlSerializer.Serialize(xmlWriter, dto, xmlSerializerNamespaces);
                }
                catch (Exception)
                {
                    throw;
                }
            }

            return stringBuilder.ToString();
        }
    }
}