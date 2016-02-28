namespace EfPowerTools.Models.Mapping
{
    using System.Data.Entity.ModelConfiguration;

    public class MotorcycleMap : EntityTypeConfiguration<Motorcycle>
    {
        public MotorcycleMap()
        {
            // Primary Key
            this.HasKey(t => t.MotorcycleId);

            // Properties
            this.Property(t => t.ModelName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Motorcycle", "Testna");
            this.Property(t => t.MotorcycleId).HasColumnName("MotorcycleId");
            this.Property(t => t.ModelYear).HasColumnName("ModelYear");
            this.Property(t => t.Displacement).HasColumnName("Displacement");
            this.Property(t => t.Killowatts).HasColumnName("Killowatts");
            this.Property(t => t.ModelName).HasColumnName("ModelName");
        }
    }
}