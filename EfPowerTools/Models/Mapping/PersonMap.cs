namespace EfPowerTools.Models.Mapping
{
    using System.Data.Entity.ModelConfiguration;

    public class PersonMap : EntityTypeConfiguration<Person>
    {
        public PersonMap()
        {
            // Primary Key
            this.HasKey(t => t.PersonId);

            // Properties
            this.Property(t => t.FirstName)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.LastName)
                .IsRequired()
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("Person", "Testna");
            this.Property(t => t.PersonId).HasColumnName("PersonId");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.Motorcycle_MotorcycleId).HasColumnName("Motorcycle_MotorcycleId");

            // Relationships
            this.HasOptional(t => t.Motorcycle)
                .WithMany(t => t.People)
                .HasForeignKey(d => d.Motorcycle_MotorcycleId);
        }
    }
}