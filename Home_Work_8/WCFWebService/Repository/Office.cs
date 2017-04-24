namespace WCFWebService
{
    using Model;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Office : DbContext
    {

        public Office(): base("name=Office")
        {
           Database.SetInitializer(new OfficeContextIntializer());
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}

    