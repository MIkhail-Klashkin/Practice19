namespace Test.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Test.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Test.Models.TestContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Test.Models.TestContext context)
        {
            context.Clients.AddOrUpdate(x => x.ClientId,
        new Client()
        {
            ClientId = 1,
            ClientFIO = "Kaled O'Vado",
            ClientMobile = "+31234567890",
            ClientAdress = "Yamaika, Cerbe, 21 st. avenue"
        },
        new Client()
        {
            ClientId = 2,
            ClientFIO = "Charles Lamborginy",
            ClientMobile = "+93756129123",
            ClientAdress = "Canada, Sardina, 192 Marko's street"
        },
        new Client()
        {
            ClientId = 3,
            ClientFIO = "Ashot Pavlovich",
            ClientMobile = "+79277927297",
            ClientAdress = "Russia, Rus, 98 Na Volge street"
        }
        );

            context.Cars.AddOrUpdate(x => x.CarId,
                new Car()
                {
                    CarId = 1,
                    Mk = "Volvo",
                    Model = "XC40"
                },
                new Car()
                {
                    CarId = 2,
                    Mk = "Volvo",
                    Model = "XC60"
                }, 
                new Car()
                {
                    CarId = 3,
                    Mk = "Toyota",
                    Model = "Corolla"
                }, 
                new Car()
                {
                    CarId = 4,
                    Mk = "LADA",
                    Model = "Granta"
                }, 
                new Car()
                {
                    CarId = 5,
                    Mk = "LADA",
                    Model = "Xray"
                }
                );
            context.Requests.AddOrUpdate(x => x.RequestId,
                new Request()
                {
                    RequestId = 1,
                    CarId = 2,
                    ClientId = 1,
                    TotalCost = 42600,
                    Notes = "Blue, chrome disk",
                },
                new Request()
                {
                    RequestId = 2,
                    CarId = 3,
                    ClientId = 1,
                    TotalCost = 66600,
                    Notes = "Dark grey, skin lessures",
                },
                new Request()
                {
                    RequestId = 3,
                    CarId = 4,
                    ClientId = 2,
                    TotalCost = 226000,
                    Notes = "Golden peace of ....",
                },
                new Request()
                {
                    RequestId = 4,
                    CarId = 5,
                    ClientId = 3,
                    TotalCost = 600,
                    Notes = "Just thanks for bying it",
                }
                );
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
