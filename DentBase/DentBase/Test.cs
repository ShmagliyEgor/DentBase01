using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DentBase
{
    public class Test
    {
        public int id { get; set; }
        public int idProblems { get; set; }
        public DateTime TimeRegister { get; set; }
        public decimal? Cost { get; set; }
        public int? AgePacient { get; set; }

        public void UpdateValue(MainClient mc)
        {
            AgePacient = mc.AgePacient;
        }
    }
}
