namespace HaVanThy_DoAn_WebDoTheThaoNike.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HaVanThy_DoAn_WebDoTheThaoNike.Models.NikeDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "HaVanThy_DoAn_WebDoTheThaoNike.Models.NikeDBContext";
        }

        protected override void Seed(HaVanThy_DoAn_WebDoTheThaoNike.Models.NikeDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
