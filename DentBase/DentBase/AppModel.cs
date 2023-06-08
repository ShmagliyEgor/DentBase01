using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DentBase
{
    public partial class AppModel : DbContext
    {
        public AppModel()
            : base("name=AppModel")
        {
        }

        public virtual DbSet<MainClient> MainClient { get; set; }
        public virtual DbSet<ClientProblems> ClientProblems { get; set; }
        public virtual DbSet<Avtorithation> Avtorithations { get; set; }
        public virtual DbSet<Problems> Problems { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
