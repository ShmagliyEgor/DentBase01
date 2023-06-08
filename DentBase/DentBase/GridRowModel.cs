using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace DentBase
{
    public class GridRowModel
    {
        public int idProblems { get;set; }
        public string FIO { get; set; }
        public string Description { get; set; }
        public DateTime TimeRegister { get; set; }
        public int? Cost { get; set; }
        public int? AgePacient { get; set; }

        public void SetValue(int problemID, string fio,string description ,DateTime timeRegister, int? cost, int? age)
        {
            idProblems = problemID;
            FIO = fio;
            TimeRegister = timeRegister;
            Cost = cost;
            AgePacient = age;
            Description = description;
        }
    }
}
