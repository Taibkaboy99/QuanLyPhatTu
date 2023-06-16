using System.ComponentModel.DataAnnotations;

namespace QuanLyPhatTu.Entities
{
    public class PhatTus
    {
        [Key]
        public int PhatTuId { get; set; }
        public string Ho { get; set; }
        public string TenDem { get; set; }
        public string Ten { get; set; }
        public string PhapDanh { get; set; }
        //public byte[]? AnhChup { get; set; }
        public string AnhChup { get; set; }
        public string? SoDienThoai { get; set; }
        public string? Email { get; set; }
        public DateTime NgaySinh { get; set; }
        public DateTime? NgayXuatGia { get; set; }
        public bool DaHoanTuc { get; set; }
        public DateTime? NgayHoanTuc { get; set; }
        public string GioiTinh { get; set; }
        public int? KieuThanhVienId { get; set; }
        public KieuThanhViens? KieuThanhVien { get; set; }
        public DateTime? NgayCapNhat { get; set; }
        public string Password { get; set; }
        public int? ChuaId { get; set; }
        public Chuas? Chuas { get; set; }
        public IEnumerable<DonDangKys>? DonDangKys { get; set; }
        public IEnumerable<PhatTuDaoTrangs>? PhatTuDaoTrangs { get; set; }
        public IEnumerable<DaoTrangs>? DaoTrangs { get; set; }   
        public PhatTus() {}
    }
}
