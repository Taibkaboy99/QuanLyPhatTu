using System.ComponentModel.DataAnnotations;

namespace QuanLyPhatTu.Entities
{
    public class Chuas
    {
        [Key]
        public int ChuaId { get; set; }
        public string TenChua { get; set; }
        public DateTime NgayThanhLap { get; set; }
        public string DiaChi { get; set; }
        public string TruTri { get; set; }
        public DateTime CapNhat { get; set; } 
        public IEnumerable<PhatTus> PhatTus { get; set; }
        public Chuas() {}
    }
}
