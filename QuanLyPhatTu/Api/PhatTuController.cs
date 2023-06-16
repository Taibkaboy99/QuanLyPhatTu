using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuanLyPhatTu.Entities;
using QuanLyPhatTu.IService;
using QuanLyPhatTu.Service;
using QuanLyPhatTu.Constant;
using QuanLyPhatTu.Helper;

namespace QuanLyPhatTu.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhatTuController : ControllerBase
    {
        private readonly IPhatTuService phatTuService;
        public PhatTuController()
        {
            phatTuService= new PhatTuService();
        }
        [HttpPost]
        public IActionResult ThemPhatTu([FromBody] PhatTus phattu)
        {
            var res = phatTuService.ThemPhatTu(phattu);
            if(res == ErrorMesage.Thanhcong)
            {
                return Ok("Thêm Phật Tử Thành Công!");
            }else if(res == ErrorMesage.SoDienThoaiDaTonTai)
            {
                return BadRequest("Them that bai! So Dien Thoai da dang ky roi!.");
            }
            else
            {
                return BadRequest("Them That Bai! Email da ton tai!");
            }
        }
        [HttpPut]
        public IActionResult SuaPhatTu([FromBody] PhatTus Phattu)
        {
            var res = phatTuService.SuaPhatTu(Phattu);
            if(res == ErrorMesage.Thanhcong)
            {
                return Ok("Sửa Phật Tử Thành Công!");
            }else
            {
                return BadRequest("Phật Tử Không Tồn Tại!");
            }
        }
        [HttpDelete]
        public IActionResult XoaPhatTu([FromQuery] int phattuid)
        {
            var res = phatTuService.XoaPhatTu(phattuid);
            if(res == ErrorMesage.Thanhcong)
            {
                return Ok("Xoá Phật Tử Thành Công!");
            }
            else
            {
                return BadRequest("Phật Tử Không Tồn Tại");
            }
        }
        [HttpGet]
        public IActionResult LayDSPhatTu([FromQuery] string? phapdanh,
                                         [FromQuery] string? ten,
                                         [FromQuery] string? gioitinh,
                                         [FromQuery] bool? TrangThai,
                                         [FromQuery]Pagination pagination = null)
        {
            return Ok(phatTuService.LayDSPhatTu(phapdanh,ten,gioitinh, TrangThai, pagination));
        }
    }
}
