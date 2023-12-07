namespace HaVanThy_DoAn_WebDoTheThaoNike.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeDataType : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.CartItems");
            AlterColumn("dbo.CartItems", "CartID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.CartItems", "CartID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.CartItems");
            AlterColumn("dbo.CartItems", "CartID", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.CartItems", "CartID");
        }
    }
}
