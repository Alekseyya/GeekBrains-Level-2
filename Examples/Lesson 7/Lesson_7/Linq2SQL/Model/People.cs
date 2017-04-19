using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;

namespace Linq2SQL.Model
{
    [Table(Name = "People")]
    public class People
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        [Column(Name = "FIO")]
        public string FIO { get; set; }
        [Column]
        public string Birthday { get; set; }
    }
}
