namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Banks",
                c => new
                    {
                        AccountNumber = c.Int(nullable: false, identity: true),
                        Amount = c.Double(nullable: false),
                        AccountType = c.String(),
                        AccHoldersName = c.String(),
                        EmailId = c.String(),
                        Address = c.String(),
                        Contact = c.Long(nullable: false),
                        DOB = c.DateTime(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.AccountNumber);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Banks");
        }
    }
}
