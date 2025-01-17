﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TruongMamNon.BackendApi.Data.EF;
using TruongMamNon.BackendApi.Data.Entities;
using TruongMamNon.BackendApi.Helpers;
using TruongMamNon.BackendApi.Interfaces.MamNon;
using TruongMamNon.BackendApi.Utilities.Constants;
using TruongMamNon.BackendApi.Utilities.Hash;
using TruongMamNon.BackendApi.ViewModels.MamNon;
using TruongMamNon.BackendApi.ViewModels.NhanSu;

namespace TruongMamNon.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NhanSusController : ControllerBase
    {
        private readonly TruongMamNonDbContext _context;

        public NhanSusController(TruongMamNonDbContext context)
        {
            _context = context;
        }

        //[HttpPost]
        //public async Task<IActionResult> PostNhanSu(CreateNhanSuVm model)
        //{
        //    if (model.MaLopHoc == 0)
        //    {
        //        model.MaLopHoc = null;
        //    }
        //    var nhanSu = new NhanSu()
        //    {
        //        Id = -1,
        //        MaNhanSu = "a",
        //        Ho = model.Ho,
        //        Ten = model.Ten,
        //        GioiTinh = model.GioiTinh,
        //        MaKhoiLop = model.MaKhoiLop,
        //        MaLopHoc = model.MaLopHoc,
        //        NgayNhapHoc = model.NgayNhapHoc,
        //        TrangThaiHoc = model.TrangThaiHoc,
        //        LyDoNghiHoc = model.LyDoNghiHoc,
        //        NgayCapNhat = model.NgayCapNhat,
        //        NgaySinh = model.NgaySinh,
        //        NoiSinh = model.NoiSinh,
        //        DanToc = model.DanToc,
        //        TonGiao = model.TonGiao,
        //        QuocTich = model.QuocTich,
        //        GhiChu = model.GhiChu,
        //        HoKhau = model.HoKhau,
        //        DiaChi = model.DiaChi,
        //        HinhAnh = model.HinhAnh,
        //        MatKhau = MD5Hash.MD5(SystemConstant.dfStudentPassword),
        //        TrangThaiTaiKhoan = "Kích hoạt",
        //        HoTenPhuHuynh = model.HoTenPhuHuynh,
        //        NamSinhPhuHuynh = model.NamSinhPhuHuynh,
        //        CMNDPhuHuynh = model.CMNDPhuHuynh,
        //        SDTPhuHuynh = model.SDTPhuHuynh,
        //        NgheNghiepPhuHuynh = model.NgheNghiepPhuHuynh,
        //        EmailPhuHuynh = model.EmailPhuHuynh,
        //        DiaChiPhuHuynh = model.DiaChiPhuHuynh
        //    };
        //    _context.NhanSus.Add(nhanSu);
        //    var result = await _context.SaveChangesAsync();
        //    if (result > 0)
        //    {
        //        return CreatedAtAction(nameof(GetByMa), new { ma = nhanSu.MaNhanSu }, model);
        //    }
        //    return BadRequest(new ApiBadRequestResponse("Tạo mới không thành công"));
        //}

        [HttpGet]
        public async Task<IActionResult> GetNhanSus()
        {
            var nhanSus = _context.NhanSus.Include(x => x.PhongBan).Include(x => x.LoaiNhanSu).Include(x => x.ChucVu).Include(x => x.KhoiLop);
            var nhanSuVms = await nhanSus.Select(x => new NhanSuVm()
            {
                MaNhanSu = x.MaNhanSu,
                Ho = x.Ho,
                Ten = x.Ten,
                GioiTinh = x.GioiTinh,
                NgaySinh = x.NgaySinh,
                NoiSinh = x.NoiSinh,
                CMND = x.CMND,
                NgayCap = x.NgayCap,
                DanToc = x.DanToc,
                TonGiao = x.TonGiao,
                QuocTich = x.QuocTich,
                NgayVaoTruong = x.NgayVaoTruong,
                TrangThaiLamViec = x.TrangThaiLamViec,
                LyDoThoiViec = x.LyDoThoiViec,
                SoDienThoai = x.SoDienThoai,
                Email = x.Email,
                HoKhau = x.HoKhau,
                DiaChi = x.DiaChi,
                HinhAnh = x.HinhAnh,
                TrangThaiTaiKhoan = x.TrangThaiTaiKhoan,

                PhongBan = x.PhongBan,
                LoaiNhanSu = x.LoaiNhanSu,
                ChucVu = x.ChucVu,
                KhoiLop = x.KhoiLop,
            }).ToListAsync();
            return Ok(nhanSuVms);
        }

        //[HttpGet("{ma}")]
        //public async Task<IActionResult> GetByMa(int ma)
        //{
        //    var nhanSu = await _context.NhanSus.FindAsync(ma);
        //    if (nhanSu == null)
        //    {
        //        return NotFound(new ApiNotFoundResponse($"Không tìm thấy mã: {ma}"));
        //    }
        //    NhanSuVm nhanSuVm = new NhanSuVm()
        //    {
        //        MaNhanSu = nhanSu.MaNhanSu,
        //        Ho = nhanSu.Ho,
        //        Ten = nhanSu.Ten,
        //        GioiTinh = nhanSu.GioiTinh,
        //        MaLopHoc = nhanSu.MaLopHoc,
        //        NgayNhapHoc = nhanSu.NgayNhapHoc,
        //        TrangThaiHoc = nhanSu.TrangThaiHoc,
        //        LyDoNghiHoc = nhanSu.LyDoNghiHoc,
        //        NgayCapNhat = nhanSu.NgayCapNhat,
        //        NgaySinh = nhanSu.NgaySinh,
        //        NoiSinh = nhanSu.NoiSinh,
        //        DanToc = nhanSu.DanToc,
        //        TonGiao = nhanSu.TonGiao,
        //        QuocTich = nhanSu.QuocTich,
        //        GhiChu = nhanSu.GhiChu,
        //        HoKhau = nhanSu.HoKhau,
        //        DiaChi = nhanSu.DiaChi,
        //        HinhAnh = nhanSu.HinhAnh,
        //        HoTenPhuHuynh = nhanSu.HoTenPhuHuynh,
        //        NamSinhPhuHuynh = nhanSu.NamSinhPhuHuynh,
        //        CMNDPhuHuynh = nhanSu.CMNDPhuHuynh,
        //        SDTPhuHuynh = nhanSu.SDTPhuHuynh,
        //        NgheNghiepPhuHuynh = nhanSu.NgheNghiepPhuHuynh,
        //        EmailPhuHuynh = nhanSu.EmailPhuHuynh,
        //        DiaChiPhuHuynh = nhanSu.DiaChiPhuHuynh,
        //        KhoiLop = nhanSu.KhoiLop,
        //        LopHoc = nhanSu.LopHoc,
        //    };
        //    return Ok(nhanSuVm);
        //}

        //[HttpPut("{ma}")]
        //public async Task<IActionResult> PutNhanSu(int ma, CreateNhanSuVm model)
        //{
        //    var nhanSu = await _context.NhanSus.FindAsync(ma);
        //    if (nhanSu == null)
        //    {
        //        return NotFound(new ApiNotFoundResponse($"Không tìm thấy mã: {ma}"));
        //    }
        //    nhanSu.Ho = model.Ho;
        //    nhanSu.Ten = model.Ten;
        //    nhanSu.GioiTinh = model.GioiTinh;
        //    nhanSu.MaLopHoc = model.MaLopHoc;
        //    nhanSu.NgayNhapHoc = model.NgayNhapHoc;
        //    nhanSu.TrangThaiHoc = model.TrangThaiHoc;
        //    nhanSu.LyDoNghiHoc = model.LyDoNghiHoc;
        //    nhanSu.NgayCapNhat = model.NgayCapNhat;
        //    nhanSu.NgaySinh = model.NgaySinh;
        //    nhanSu.NoiSinh = model.NoiSinh;
        //    nhanSu.DanToc = model.DanToc;
        //    nhanSu.TonGiao = model.TonGiao;
        //    nhanSu.QuocTich = model.QuocTich;
        //    nhanSu.GhiChu = model.GhiChu;
        //    nhanSu.HoKhau = model.HoKhau;
        //    nhanSu.DiaChi = model.DiaChi;
        //    nhanSu.HinhAnh = model.HinhAnh;
        //    nhanSu.HoTenPhuHuynh = model.HoTenPhuHuynh;
        //    nhanSu.NamSinhPhuHuynh = model.NamSinhPhuHuynh;
        //    nhanSu.CMNDPhuHuynh = model.CMNDPhuHuynh;
        //    nhanSu.SDTPhuHuynh = model.SDTPhuHuynh;
        //    nhanSu.NgheNghiepPhuHuynh = model.NgheNghiepPhuHuynh;
        //    nhanSu.EmailPhuHuynh = model.EmailPhuHuynh;
        //    nhanSu.DiaChiPhuHuynh = model.DiaChiPhuHuynh;
        //    _context.NhanSus.Update(nhanSu);
        //    var result = await _context.SaveChangesAsync();
        //    if (result > 0)
        //    {
        //        return NoContent();
        //    }
        //    return BadRequest(new ApiBadRequestResponse("Cập nhật không thành công"));
        //}

        //[HttpDelete("{ma}")]
        //public async Task<IActionResult> DeleteNhanSu(string ma)
        //{
        //    var nhanSu = await _context.NhanSus.FindAsync(ma);
        //    if (nhanSu == null)
        //    {
        //        return NotFound(new ApiNotFoundResponse($"Không tìm thấy mã: {ma}"));
        //    }
        //    _context.NhanSus.Remove(nhanSu);
        //    var result = await _context.SaveChangesAsync();
        //    if (result > 0)
        //    {
        //        NhanSuVm nhanSuVm = new NhanSuVm()
        //        {
        //            Id = nhanSu.Id,
        //            MaNhanSu = nhanSu.MaNhanSu,
        //            Ho = nhanSu.Ho,
        //            Ten = nhanSu.Ten,
        //            GioiTinh = nhanSu.GioiTinh,
        //            MaLopHoc = nhanSu.MaLopHoc,
        //            NgayNhapHoc = nhanSu.NgayNhapHoc,
        //            TrangThaiHoc = nhanSu.TrangThaiHoc,
        //            LyDoNghiHoc = nhanSu.LyDoNghiHoc,
        //            NgayCapNhat = nhanSu.NgayCapNhat,
        //            NgaySinh = nhanSu.NgaySinh,
        //            NoiSinh = nhanSu.NoiSinh,
        //            DanToc = nhanSu.DanToc,
        //            TonGiao = nhanSu.TonGiao,
        //            QuocTich = nhanSu.QuocTich,
        //            GhiChu = nhanSu.GhiChu,
        //            HoKhau = nhanSu.HoKhau,
        //            DiaChi = nhanSu.DiaChi,
        //            HinhAnh = nhanSu.HinhAnh,
        //            HoTenPhuHuynh = nhanSu.HoTenPhuHuynh,
        //            NamSinhPhuHuynh = nhanSu.NamSinhPhuHuynh,
        //            CMNDPhuHuynh = nhanSu.CMNDPhuHuynh,
        //            SDTPhuHuynh = nhanSu.SDTPhuHuynh,
        //            NgheNghiepPhuHuynh = nhanSu.NgheNghiepPhuHuynh,
        //            EmailPhuHuynh = nhanSu.EmailPhuHuynh,
        //            DiaChiPhuHuynh = nhanSu.DiaChiPhuHuynh,
        //        };
        //        return Ok(nhanSuVm);
        //    }

        //    return BadRequest(new ApiBadRequestResponse("Xóa không thành công"));
        //}
    }
}