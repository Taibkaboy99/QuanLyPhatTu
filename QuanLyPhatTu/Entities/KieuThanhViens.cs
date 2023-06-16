using System.ComponentModel.DataAnnotations;

namespace QuanLyPhatTu.Entities
{
    public class KieuThanhViens
    {
        [Key]
        public int KieuThanhVienId { get; set; }
        public string Code { get; set; }
        public string TenKieu { get; set; }
        public IEnumerable<PhatTus> PhatTus { get; set; }
        public KieuThanhViens() { }
    }
}
