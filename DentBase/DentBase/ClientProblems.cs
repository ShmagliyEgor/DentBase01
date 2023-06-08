using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace DentBase
{
    [Table("ClientProblems")]
    public class ClientProblems
    {
        public int id { get; set; }
        public int idClient { get; set; }
        public int idProblems { get; set; }
    }
}
