namespace HaVanThy_DoAn_WebDoTheThaoNike.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddValidate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "ProductName", c => c.String(nullable: false));
            AlterColumn("dbo.Products", "Description", c => c.String(nullable: false, maxLength: 1000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Description", c => c.String());
            AlterColumn("dbo.Products", "ProductName", c => c.String());
        }
    }
}
