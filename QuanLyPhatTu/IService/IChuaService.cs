using QuanLyPhatTu.Constant;
using QuanLyPhatTu.Entities;
using QuanLyPhatTu.Helper;

namespace QuanLyPhatTu.IService
{
    public interface IChuaService
    {
        ErrorMesage ThemChua(Chuas chua);
        ErrorMesage SuaChua(Chuas Chua);
        ErrorMesage XoaChua(int chuaid);
        public IQueryable<Chuas> LayDSChua(string? keyword, Pagination pagination = null);
    }
}
