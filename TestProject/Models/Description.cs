using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestProject.Models
{
    public class Description
    {
        public int ID { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime DateEndOfActuality { get; set; }
        public string DescriptionOfObject { get; set; }
        public string Category { get; set; }
    }
}
