using Microsoft.EntityFrameworkCore;
using QuanLyPhatTu.Entities;

namespace QuanLyPhatTu
{
    public class ApDbContext:DbContext
    {
        public virtual DbSet<Chuas> Chuas { get; set; }
        public virtual DbSet<DaoTrangs> DaoTrangs { get; set; }
        public virtual DbSet<DonDangKys> DonDangKys { get; set; }
        public virtual DbSet<KieuThanhViens> KieuThanhViens { get; set; }
        public virtual DbSet<PhatTuDaoTrangs> PhatTuDaoTrangs { get; set; }
        public virtual DbSet <PhatTus> PhatTus { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-QPOO44O\\DANGTAI ;Database = QuanLyPhatTu; Trusted_Connection = True;TrustServerCertificate=True; ");
        }
    }
}
