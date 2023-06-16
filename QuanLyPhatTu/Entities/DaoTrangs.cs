using System.ComponentModel.DataAnnotations;

namespace QuanLyPhatTu.Entities
{
    public class DaoTrangs
    {
        [Key]
        public int DaoTrangId { get; set; }
        public string NoiToChuc { get; set; }
        public int SoThanhVienThamGia { get; set; }
        public int NguoiChuTriId { get; set; }
        public PhatTus NguoiChuTri { get; set; }
        public DateTime ThoiGianToChuc { get; set; }
        public string NoiDung { get; set; }
        public bool DaKetThuc { get; set; }
        public IEnumerable<PhatTuDaoTrangs> PhatTuDaoTrangs { get; set; }
        public DaoTrangs() { }
    }
}
