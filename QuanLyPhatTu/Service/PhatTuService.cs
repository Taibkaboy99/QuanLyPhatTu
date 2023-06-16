using Microsoft.EntityFrameworkCore;
using QuanLyPhatTu.Constant;
using QuanLyPhatTu.Entities;
using QuanLyPhatTu.Helper;
using QuanLyPhatTu.IService;

namespace QuanLyPhatTu.Service
{
    public class PhatTuService : IPhatTuService
    {
        private readonly ApDbContext DbContext;
        public PhatTuService()
        {
            DbContext = new ApDbContext();
        }
        public PageResult<PhatTus> LayDSPhatTu(string? phapdanh,string? ten,string? gioitinh,bool? TrangThai,Pagination pagination = null)
        {
            var dsphattu = DbContext.PhatTus.AsQueryable();
            if(phapdanh != null)
            {
                dsphattu = dsphattu.Where(x => x.PhapDanh.ToLower().Contains(phapdanh.ToLower()));                                 
            }
            if (ten != null)
            {
                dsphattu = dsphattu.Where(x => x.Ten.ToLower().Contains(ten.ToLower()));
            }
            if (gioitinh != null)
            {
                dsphattu = dsphattu.Where(x => x.GioiTinh.ToLower().Contains(gioitinh.ToLower()));
            }
            if (TrangThai != null)
            {
                dsphattu = dsphattu.Where(x => x.DaHoanTuc == TrangThai);
            }
            var result = PageResult<PhatTus>.TopPageResult(pagination, dsphattu);
            pagination.TotalCount = dsphattu.Count();
            return new PageResult<PhatTus>(pagination, result);

        }

        public ErrorMesage SuaPhatTu(PhatTus Phattu)
        {
            var Phattuhientai = DbContext.PhatTus.FirstOrDefault(x => x.PhatTuId == Phattu.PhatTuId);
            if (Phattuhientai != null)
            {
                using (var trans = DbContext.Database.BeginTransaction())
                {
                    Phattuhientai.Ho = Phattu.Ho;
                    Phattuhientai.TenDem = Phattu.TenDem;
                    Phattuhientai.Ten = Phattu.Ten;
                    Phattuhientai.PhapDanh = Phattu.PhapDanh;
                    Phattuhientai.AnhChup = Phattu.AnhChup;
                    Phattuhientai.SoDienThoai = Phattu.SoDienThoai;
                    Phattuhientai.Email = Phattu.Email;
                    Phattuhientai.NgaySinh = Phattu.NgaySinh;
                    Phattuhientai.NgayXuatGia = Phattu.NgayXuatGia;
                    Phattuhientai.DaHoanTuc = Phattu.DaHoanTuc;
                    Phattuhientai.NgayHoanTuc = Phattu.NgayHoanTuc;
                    Phattuhientai.GioiTinh = Phattu.GioiTinh;
                    Phattuhientai.KieuThanhVienId = Phattu.KieuThanhVienId;
                    Phattuhientai.NgayCapNhat = Phattu.NgayCapNhat;
                    Phattuhientai.ChuaId = Phattu.ChuaId;
                    DbContext.Update(Phattuhientai);
                    DbContext.SaveChanges();
                    trans.Commit();
                    return ErrorMesage.Thanhcong;
                }
            }
            else return ErrorMesage.PhatTuKhongTonTai;
        }

        public ErrorMesage ThemPhatTu(PhatTus phattu)
        {
            if (!DbContext.PhatTus.Any(x => x.SoDienThoai.ToLower().Contains(phattu.SoDienThoai.ToLower())))
            {
                if (!DbContext.PhatTus.Any(x => x.Email.ToLower().Contains(phattu.Email.ToLower())))
                {
                    using(var trans = DbContext.Database.BeginTransaction())
                    {
                        DbContext.PhatTus.Add(phattu);
                        DbContext.SaveChanges();
                        phattu.Ho = phattu.Ho.ToUpper();
                        phattu.TenDem = phattu.TenDem.ToUpper();
                        phattu.Ten = phattu.Ten.ToUpper();
                        DbContext.Update(phattu);
                        DbContext.SaveChanges();
                        trans.Commit();
                        return ErrorMesage.Thanhcong;
                    }

                }
                else return ErrorMesage.EmailDaTonTai;
            }
            else return ErrorMesage.SoDienThoaiDaTonTai;
        }

        public ErrorMesage XoaPhatTu(int phattuid)
        {
            var checkphattu = DbContext.PhatTus.Find(phattuid);
            if(checkphattu != null)
            {
                DbContext.Remove(checkphattu);
                DbContext.SaveChanges();
                return ErrorMesage.Thanhcong;
            }
            else
            {
                return ErrorMesage.PhatTuKhongTonTai;
            }
        }
    }
}
