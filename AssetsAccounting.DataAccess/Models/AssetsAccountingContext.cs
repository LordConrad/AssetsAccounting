using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetsAccounting.DataAccess.Models
{
    public class AssetsAccountingContext : DbContext
    {
        public AssetsAccountingContext()
            : base("DefaultConnection")
        {
            Database.SetInitializer(new DatabaseInitializer());
        }

        public DbSet<Asset> Assets { get; set; }
        public DbSet<AssetType> AssetTypes { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Responsible> Responsibles { get; set; }
        public DbSet<ResponsiblesAssets> ResponsiblesAssets { get; set; }
        public DbSet<StoredAsset> StoredAssets { get; set; }
        public DbSet<TrashedAsset> TrashedAssets { get; set; }
        public DbSet<User> Users { get; set; }
    }

    public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<AssetsAccountingContext>
    {
        protected override void Seed(AssetsAccountingContext context)
        {
            context.Users.Add(new User
            {
                Username = "admin",
                Password = "adm1n",
                IsEditEnable = true
            });
            context.Users.Add(new User
            {
                Username = "user",
                Password = "u5er"
            });
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
