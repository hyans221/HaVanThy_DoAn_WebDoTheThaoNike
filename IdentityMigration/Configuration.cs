namespace HaVanThy_DoAn_WebDoTheThaoNike.IdentityMigration
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HaVanThy_DoAn_WebDoTheThaoNike.Identity.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"IdentityMigration";
        }

        protected override void Seed(HaVanThy_DoAn_WebDoTheThaoNike.Identity.AppDbContext context)
        {

        }
    }
}
