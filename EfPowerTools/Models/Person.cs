namespace EfPowerTools.Models
{
    using System;

    public partial class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<int> Motorcycle_MotorcycleId { get; set; }
        public virtual Motorcycle Motorcycle { get; set; }
    }
}