namespace HaVanThy_DoAn_WebDoTheThaoNike.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddValiData : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categories", "CategoryName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Categories", "CategoryName", c => c.String());
        }
    }
}
