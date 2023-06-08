namespace DentBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MainClient")]
    public partial class MainClient
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string FIO { get; set; }
        public int? AgePacient { get; set; }

        public void UpdateValue(MainClient mc)
        {
            FIO = mc.FIO;
            AgePacient = mc.AgePacient;
        }
    }
}
