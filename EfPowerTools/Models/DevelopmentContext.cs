namespace EfPowerTools.Models
{
    using EfPowerTools.Models.Mapping;
    using System.Data.Entity;

    public partial class DevelopmentContext : DbContext
    {
        static DevelopmentContext()
        {
            Database.SetInitializer<DevelopmentContext>(null);
        }

        public DevelopmentContext()
            : base("Name=DevelopmentContext")
        {
        }

        public DbSet<Motorcycle> Motorcycles { get; set; }
        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MotorcycleMap());
            modelBuilder.Configurations.Add(new PersonMap());
        }
    }
}