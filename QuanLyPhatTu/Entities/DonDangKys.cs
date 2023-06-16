using System.ComponentModel.DataAnnotations;

namespace QuanLyPhatTu.Entities
{
    public class DonDangKys
    {
        [Key]
        public int DonDangKyId { get; set; }
        public int PhatTuId { get; set; }
        public PhatTus? PhatTu { get; set; }
        public int TrangThaiDon { get; set; }
        public DateTime NgayGuiDon { get; set; }
        public DateTime NgaySuLy { get; set; }
        public int? NguoiSuLyId { get; set; }
        public DonDangKys () { }
    }
}
