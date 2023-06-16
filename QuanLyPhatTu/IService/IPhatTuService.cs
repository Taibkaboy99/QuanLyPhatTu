using QuanLyPhatTu.Constant;
using QuanLyPhatTu.Entities;
using QuanLyPhatTu.Helper;

namespace QuanLyPhatTu.IService
{
    public interface IPhatTuService
    {
        ErrorMesage ThemPhatTu(PhatTus phattu);
        ErrorMesage SuaPhatTu(PhatTus Phattu);
        ErrorMesage XoaPhatTu(int phattuid);
        public PageResult<PhatTus> LayDSPhatTu(string? phapdanh,string? ten,string? gioitinh, bool? TrangThai, Pagination pagination = null);
    }
}
