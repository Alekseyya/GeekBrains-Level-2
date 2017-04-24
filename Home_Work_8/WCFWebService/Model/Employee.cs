using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFWebService.Model
{
    [DataContract]
    [Table("Employees")]
    public class Employee
    {
        [DataMember(IsRequired = true)]
        public int Id { get; set; }
        [DataMember(IsRequired = true)]
        public string Name { get; set; }
        [DataMember(IsRequired = true)]
        public int Age { get; set; }
        [DataMember(IsRequired = true)]
        public double Salary { get; set; }
        [DataMember(IsRequired = true)]
        public int? DepartmentId { get; set; }
        [IgnoreDataMember]
        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }
    }
}