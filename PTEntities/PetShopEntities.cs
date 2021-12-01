using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PTEntities
{
    public partial class PetShopEntities : DbContext
    {
        public PetShopEntities()
            : base("name=PetShopEntities")
        {
        }

        public virtual DbSet<Shops_Base> Shops_Base { get; set; }
        public virtual DbSet<Users_Base> Users_Base { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
