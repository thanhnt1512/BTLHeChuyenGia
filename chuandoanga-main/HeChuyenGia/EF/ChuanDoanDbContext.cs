using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace HeChuyenGia.EF
{
    public partial class ChuanDoanDbContext : DbContext
    {
        public ChuanDoanDbContext()
            : base("name=ChuanDoanDbContext")
        {
        }

        public virtual DbSet<BENH_GA> BENH_GA { get; set; }
        public virtual DbSet<CAU_HOI> CAU_HOI { get; set; }
        public virtual DbSet<TAP_LUAT> TAP_LUAT { get; set; }
        public virtual DbSet<TRIEU_CHUNG> TRIEU_CHUNG { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CAU_HOI>()
                .HasMany(e => e.TRIEU_CHUNG)
                .WithOptional(e => e.CAU_HOI)
                .HasForeignKey(e => e.ID_CAUHOI);
        }
    }
}
