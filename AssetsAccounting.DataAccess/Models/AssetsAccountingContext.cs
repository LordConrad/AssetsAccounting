﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetsAccounting.DataAccess.Models
{
    public class AssetsAccountingContext : DbContext
    {
        public AssetsAccountingContext() : base("DefaultConnection")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<AssetsAccountingContext>());
        }

        public DbSet<Asset> Assets { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Responsible> Responsibles { get; set; }
        public DbSet<ResponsiblesAssets> ResponsiblesAssets { get; set; }
        public DbSet<StoredAsset> StoredAssets { get; set; }
        public DbSet<TrashedAsset> TrashedAssets { get; set; }
    }
}
