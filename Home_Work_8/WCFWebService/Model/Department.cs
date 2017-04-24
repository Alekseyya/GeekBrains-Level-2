using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFWebService.Model
{
    [DataContract]
    [Table("Departments")]
    public class Department
    {
        public Department()
        {
            this.Employees = new List<Employee>();
        }
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [IgnoreDataMember]
        public virtual ICollection<Employee> Employees { get; set; }
    }
}