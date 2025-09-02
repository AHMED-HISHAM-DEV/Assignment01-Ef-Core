using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Assignment01.Models
{
    public class Course
    {
        [Key]
        public int ID { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        public int Duration { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string Description { get; set; }

        public int Top_ID { get; set; }
    }
}
