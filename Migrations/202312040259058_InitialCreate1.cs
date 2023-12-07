namespace HaVanThy_DoAn_WebDoTheThaoNike.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CartItems",
                c => new
                    {
                        CartID = c.String(nullable: false, maxLength: 128),
                        ProductID = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CartID)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.ProductID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CartItems", "ProductID", "dbo.Products");
            DropIndex("dbo.CartItems", new[] { "ProductID" });
            DropTable("dbo.CartItems");
        }
    }
}
