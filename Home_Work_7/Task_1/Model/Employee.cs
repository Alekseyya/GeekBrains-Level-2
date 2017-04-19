using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1.Model
{
    [Table("Employees")]
    public class Employee
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public int? DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }
    }
}
