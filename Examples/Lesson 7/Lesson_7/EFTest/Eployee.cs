namespace EFTest
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Eployee : DbContext
    {
        public Eployee() : base("name=Eployee")
        {
        }

        public virtual DbSet<Eploee> Eploees { get; set; }
    }

    public class Eploee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}