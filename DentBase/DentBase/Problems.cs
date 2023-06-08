using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace DentBase
{
    [Table("Problems")]
    public class Problems
    {
        public int id { get; set; }
        [StringLength(100)]
        public string Description { get; set; }

        public DateTime TimeRegister { get; set; }

        [Column(TypeName = "money")]
        public int? Cost { get; set; }
        public void UpdateValue(Problems pr)
        {
            Description = pr.Description;
            TimeRegister = pr.TimeRegister;
            Cost = pr.Cost;
        }
    }
}
