namespace EfPowerTools.Models
{
    using System.Collections.Generic;

    public partial class Motorcycle
    {
        public Motorcycle()
        {
            this.People = new List<Person>();
        }

        public int MotorcycleId { get; set; }
        public int ModelYear { get; set; }
        public int Displacement { get; set; }
        public decimal Killowatts { get; set; }
        public string ModelName { get; set; }
        public virtual ICollection<Person> People { get; set; }
    }
}