namespace MvcTest11.Domain.Entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EFDbContext : DbContext
    {
        public EFDbContext()
            : base("name=EFDbContext")
        {
        }

        public virtual DbSet<tvCustomer> tvCustomers { get; set; }
        public virtual DbSet<tvCustomerOrdersHistory> tvCustomerOrdersHistories { get; set; }
        public virtual DbSet<MyTestTable> MyTestTables { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<tvCustomer>().MapToStoredProcedures();
        }
    }
}
