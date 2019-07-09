namespace Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        CarId = c.Int(nullable: false, identity: true),
                        Mk = c.String(),
                        Model = c.String(),
                    })
                .PrimaryKey(t => t.CarId);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ClientId = c.Int(nullable: false, identity: true),
                        ClientFIO = c.String(),
                        ClientMobile = c.String(),
                        ClientAdress = c.String(),
                    })
                .PrimaryKey(t => t.ClientId);
            
            CreateTable(
                "dbo.Requests",
                c => new
                    {
                        RequestId = c.Int(nullable: false, identity: true),
                        CarId = c.Int(nullable: false),
                        ClientId = c.Int(nullable: false),
                        TotalCost = c.Int(nullable: false),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.RequestId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Requests");
            DropTable("dbo.Clients");
            DropTable("dbo.Cars");
        }
    }
}
