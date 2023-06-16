using System.ComponentModel.DataAnnotations;

namespace QuanLyPhatTu.Entities
{
    public class PhatTuDaoTrangs
    {
        [Key]
        public int PhatTuDaoTrangId { get; set; }
        public int? PhatTuId { get; set; }
        public PhatTus? PhatTu { get; set; }
        public int DaoTrangId { get; set; }
        public DaoTrangs? DaoTrang { get; set; }
        public bool DaThamGia { get; set; }
        public string? LyDoKhongThamGia { get; set; }
        public PhatTuDaoTrangs () { }
    }
}
