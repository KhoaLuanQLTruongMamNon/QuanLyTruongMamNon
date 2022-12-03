using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TruongMamNon.BackendApi.Data.EF;
using TruongMamNon.BackendApi.Data.Entities;
using TruongMamNon.BackendApi.Helpers;
using TruongMamNon.BackendApi.ViewModels.MamNon;

namespace TruongMamNon.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HocSinhsController : ControllerBase
    {
        private readonly TruongMamNonDbContext _context;

        public HocSinhsController(TruongMamNonDbContext context)
        {
            _context = context;
        }

        //[HttpPost]
        //public async Task<IActionResult> PostHocSinh(HocSinhVm model)
        //{
        //    var hocSinh = new HocSinh()
        //    {
        //        TenLop = model.TenLop,
        //        MaKhoiLop = model.MaKhoiLop,
        //        HocPhi = model.HocPhi,
        //        MaNienHoc = model.MaNienHoc,
        //    };
        //    _context.HocSinhs.Add(hocSinh);
        //    var result = await _context.SaveChangesAsync();
        //    if (result > 0)
        //    {
        //        return CreatedAtAction(nameof(GetByMa), new { ma = hocSinh.MaLop }, model);
        //    }
        //    return BadRequest(new ApiBadRequestResponse("Tạo mới không thành công"));
        //}

        [HttpGet]
        public async Task<IActionResult> GetHocSinhs()
        {
            var hocSinhs = _context.HocSinhs.Include(x => x.LopHoc);
            var hocSinhVms = await hocSinhs.Select(x => new HocSinhVm()
            {
                MaHocSinh = x.MaHocSinh,
                Ho = x.Ho,
                Ten = x.Ten,
                GioiTinh = x.GioiTinh,
                MaLopHoc = x.MaLopHoc,
                NgayNhapHoc = x.NgayNhapHoc,
                TrangThaiHoc = x.TrangThaiHoc,
                LyDoNghiHoc = x.LyDoNghiHoc,
                NgayCapNhat = x.NgayCapNhat,
                NgaySinh = x.NgaySinh,
                NoiSinh = x.NoiSinh,
                DanToc = x.DanToc,
                TonGiao = x.TonGiao,
                QuocTich = x.QuocTich,
                GhiChu = x.GhiChu,
                HoKhau = x.HoKhau,
                DiaChi = x.DiaChi,
                HinhAnh = x.HinhAnh,
                HoTenPhuHuynh = x.HoTenPhuHuynh,
                NamSinhPhuHuynh = x.NamSinhPhuHuynh,
                CMNDPhuHuynh = x.CMNDPhuHuynh,
                SDTPhuHuynh = x.SDTPhuHuynh,
                NgheNghiepPhuHuynh = x.NgheNghiepPhuHuynh,
                EmailPhuHuynh = x.EmailPhuHuynh,
                DiaChiPhuHuynh = x.DiaChiPhuHuynh,
                LopHoc = x.LopHoc,
            }).ToListAsync();
            return Ok(hocSinhVms);
        }

        //[HttpGet("{ma}")]
        //public async Task<IActionResult> GetByMa(int ma)
        //{
        //    var hocSinh = await _context.HocSinhs.FindAsync(ma);
        //    if (hocSinh == null)
        //    {
        //        return NotFound(new ApiNotFoundResponse($"Không tìm thấy mã: {ma}"));
        //    }
        //    HocSinhVm hocSinhVm = new HocSinhVm()
        //    {
        //        //MaLop = hocSinh.MaLop,
        //        //TenLop = hocSinh.TenLop,
        //        //MaKhoiLop = hocSinh.MaKhoiLop,
        //        //HocPhi = hocSinh.HocPhi,
        //        //MaNienHoc = hocSinh.MaNienHoc
        //    };
        //    return Ok(hocSinhVm);
        //}

        //[HttpPut("{ma}")]
        //public async Task<IActionResult> PutHocSinh(int ma, HocSinhVm model)
        //{
        //    var hocSinh = await _context.HocSinhs.FindAsync(ma);
        //    if (hocSinh == null)
        //    {
        //        return NotFound(new ApiNotFoundResponse($"Không tìm thấy mã: {ma}"));
        //    }
        //    //hocSinh.MaLop = model.MaLop;
        //    //hocSinh.TenLop = model.TenLop;
        //    //hocSinh.MaKhoiLop = model.MaKhoiLop;
        //    //hocSinh.HocPhi = model.HocPhi;
        //    //hocSinh.MaNienHoc = model.MaNienHoc;
        //    _context.HocSinhs.Update(hocSinh);
        //    var result = await _context.SaveChangesAsync();
        //    if (result > 0)
        //    {
        //        return NoContent();
        //    }
        //    return BadRequest(new ApiBadRequestResponse("Cập nhật không thành công"));
        //}

        //[HttpDelete("{ma}")]
        //public async Task<IActionResult> DeleteHocSinh(int ma)
        //{
        //    var hocSinh = await _context.HocSinhs.FindAsync(ma);
        //    if (hocSinh == null)
        //    {
        //        return NotFound(new ApiNotFoundResponse($"Không tìm thấy mã: {ma}"));
        //    }
        //    _context.HocSinhs.Remove(hocSinh);
        //    var result = await _context.SaveChangesAsync();
        //    if (result > 0)
        //    {
        //        HocSinhVm hocSinhVm = new HocSinhVm()
        //        {
        //            //MaLop = hocSinh.MaLop,
        //            //TenLop = hocSinh.TenLop,
        //            //MaKhoiLop = hocSinh.MaKhoiLop,
        //            //HocPhi = hocSinh.HocPhi,
        //            //MaNienHoc = hocSinh.MaNienHoc,
        //        };
        //        return Ok(hocSinhVm);
        //    }
        //    return BadRequest(new ApiBadRequestResponse("Xóa không thành công"));
        //}
    }
}