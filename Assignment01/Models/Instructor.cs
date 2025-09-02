using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01.Models
{
    public class Instructor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }
        public decimal HourRateBouns { get; set; }
        public int Dept_ID { get; set; }
    }
}
