using Microsoft.AspNetCore.Mvc.Diagnostics;
using Microsoft.EntityFrameworkCore;
using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.Data.Extensions
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KhoiLop>().HasData(
                new KhoiLop() { MaKhoiLop = 1, TenKhoiLop = "3-12 tháng - KL0312", GhiChu = "" },
                new KhoiLop() { MaKhoiLop = 3, TenKhoiLop = "13-24 tháng - KL1324", GhiChu = "" },
                new KhoiLop() { MaKhoiLop = 2, TenKhoiLop = "25-36 tháng - KL2536", GhiChu = "" },
                new KhoiLop() { MaKhoiLop = 4, TenKhoiLop = "3-4 tuổi - KLM", GhiChu = "" },
                new KhoiLop() { MaKhoiLop = 5, TenKhoiLop = "4-5 tuổi - KLC", GhiChu = "" },
                new KhoiLop() { MaKhoiLop = 6, TenKhoiLop = "5-6 tuổi - KLL", GhiChu = "" });

            modelBuilder.Entity<NienHoc>().HasData(
                new NienHoc()
                {
                    MaNienHoc = 1,
                    TenNienHoc = "Năm học 2019-2020",
                    BatDauHK1 = new DateTime(2019, 08, 01),
                    KetThucHK1 = new DateTime(2020, 01, 09),
                    BatDauHK2 = new DateTime(2020, 01, 10),
                    KetThucHK2 = new DateTime(2020, 05, 31),
                },
                new NienHoc()
                {
                    MaNienHoc = 2,
                    TenNienHoc = "Năm học 2020-2021",
                    BatDauHK1 = new DateTime(2020, 08, 01),
                    KetThucHK1 = new DateTime(2021, 01, 09),
                    BatDauHK2 = new DateTime(2021, 01, 10),
                    KetThucHK2 = new DateTime(2021, 05, 31),
                },
                new NienHoc()
                {
                    MaNienHoc = 3,
                    TenNienHoc = "Năm học 2021-2022",
                    BatDauHK1 = new DateTime(2021, 08, 01),
                    KetThucHK1 = new DateTime(2022, 01, 09),
                    BatDauHK2 = new DateTime(2022, 01, 10),
                    KetThucHK2 = new DateTime(2022, 05, 31),
                },
                new NienHoc()
                {
                    MaNienHoc = 4,
                    TenNienHoc = "Năm học 2022-2023",
                    BatDauHK1 = new DateTime(2022, 08, 01),
                    KetThucHK1 = new DateTime(2023, 01, 09),
                    BatDauHK2 = new DateTime(2023, 01, 10),
                    KetThucHK2 = new DateTime(2023, 05, 31),
                });

            modelBuilder.Entity<DanhMucThucPham>().HasData(
                new DanhMucThucPham() { MaDanhMuc = 1, TenDanhMuc = "Ngũ cốc", GhiChu = "" },
                new DanhMucThucPham() { MaDanhMuc = 2, TenDanhMuc = "Thịt và các sản phẩm từ thịt", GhiChu = "" },
                new DanhMucThucPham() { MaDanhMuc = 3, TenDanhMuc = "Thủy sản và sản phẩm thủy sản", GhiChu = "" },
                new DanhMucThucPham() { MaDanhMuc = 4, TenDanhMuc = "Rau, củ, quả và sản phẩm rau, củ, quả", GhiChu = "" },
                new DanhMucThucPham() { MaDanhMuc = 5, TenDanhMuc = "Trứng và các sản phẩm từ trứng", GhiChu = "" },
                new DanhMucThucPham() { MaDanhMuc = 6, TenDanhMuc = "Sữa tươi nguyên liệu", GhiChu = "" },
                new DanhMucThucPham() { MaDanhMuc = 7, TenDanhMuc = "Mật ong và các sản phẩm từ mật ong", GhiChu = "" },
                new DanhMucThucPham() { MaDanhMuc = 8, TenDanhMuc = "Gia vị", GhiChu = "" },
                new DanhMucThucPham() { MaDanhMuc = 9, TenDanhMuc = "Thực phẩm khác", GhiChu = "" });

            modelBuilder.Entity<ThucPham>().HasData(
                new ThucPham()
                {
                    MaThucPham = 1,
                    TenThucPham = "Chôm chôm",
                    DonViTinh = "Kg",
                    TonKho = 0,
                    HinhAnh = "",
                    MaDanhMuc = 4,
                    NangLuong = 72000,
                    ChatDam = 1500,
                    ChatBeo = 0,
                    ChatBot = 16400
                },
                new ThucPham()
                {
                    MaThucPham = 2,
                    TenThucPham = "Đậu cô ve",
                    DonViTinh = "Kg",
                    TonKho = 0,
                    HinhAnh = "",
                    MaDanhMuc = 4,
                    NangLuong = 73000,
                    ChatDam = 5000,
                    ChatBeo = 1000,
                    ChatBot = 11000
                },
                new ThucPham()
                {
                    MaThucPham = 3,
                    TenThucPham = "Thịt heo nạc",
                    DonViTinh = "Kg",
                    TonKho = 0,
                    HinhAnh = "",
                    MaDanhMuc = 2,
                    NangLuong = 139000,
                    ChatDam = 19000,
                    ChatBeo = 7000,
                    ChatBot = 0
                },
                new ThucPham()
                {
                    MaThucPham = 4,
                    TenThucPham = "Nhãn",
                    DonViTinh = "Kg",
                    TonKho = 0,
                    HinhAnh = "",
                    MaDanhMuc = 4,
                    NangLuong = 48000,
                    ChatDam = 900,
                    ChatBeo = 0,
                    ChatBot = 11000
                });

            modelBuilder.Entity<ChucVu>().HasData(
                new ChucVu() { MaChucVu = 1, TenChucVu = "Hiệu trưởng", GhiChu = "" },
                new ChucVu() { MaChucVu = 2, TenChucVu = "Phó hiệu trưởng", GhiChu = "" },
                new ChucVu() { MaChucVu = 3, TenChucVu = "Trưởng phòng", GhiChu = "" },
                new ChucVu() { MaChucVu = 4, TenChucVu = "Phó trưởng phòng", GhiChu = "" },
                new ChucVu() { MaChucVu = 5, TenChucVu = "Nhân viên", GhiChu = "" },
                new ChucVu() { MaChucVu = 6, TenChucVu = "Giáo viên", GhiChu = "" });

            modelBuilder.Entity<LopHoc>().HasData(
                new LopHoc() { MaLop = 1, TenLop = "Lớp mầm 1", MaKhoiLop = 4, SiSoToiDa = 80, HocPhi = 0, MaNienHoc = 4 },
                new LopHoc() { MaLop = 2, TenLop = "Lớp mầm 2", MaKhoiLop = 4, SiSoToiDa = 80, HocPhi = 0, MaNienHoc = 4 },
                new LopHoc() { MaLop = 3, TenLop = "Lớp mầm 3", MaKhoiLop = 4, SiSoToiDa = 80, HocPhi = 0, MaNienHoc = 4 });

            modelBuilder.Entity<HocSinh>().HasData(
                new HocSinh()
                {
                    MaHocSinh = "0",
                    Ho = "Lê Nguyễn Đại Đức",
                    Ten = "Tâm",
                    GioiTinh = "Nam",
                    MaKhoiLop = 4,
                    MaLopHoc = 1,
                    NgayNhapHoc = new DateTime(2022, 12, 3),
                    TrangThaiHoc = "Đang học",
                    LyDoNghiHoc = "",
                    NgayCapNhat = DateTime.Now,
                    NgaySinh = new DateTime(2001, 1, 10),
                    NoiSinh = "Long An",
                    DanToc = "Kinh",
                    TonGiao = "Không",
                    QuocTich = "Việt Nam",
                    GhiChu = "",
                    HoKhau = "Long An",
                    DiaChi = "HCM",
                    HinhAnh = "",
                    MatKhau = "Client@123",
                    TrangThaiTaiKhoan = "Kích hoạt",
                    HoTenPhuHuynh = "Lê Huỳnh Nam",
                    NamSinhPhuHuynh = new DateTime(1968, 1, 1),
                    CMNDPhuHuynh = "012345678910",
                    SDTPhuHuynh = "0123456789",
                    NgheNghiepPhuHuynh = "Tự do",
                    EmailPhuHuynh = "lenguyenductamht@gmail.com",
                    DiaChiPhuHuynh = "140 Lê trọng tấn",
                });

            modelBuilder.Entity<DanhMucThucDon>().HasData(
                new DanhMucThucDon()
                {
                    MaDanhMuc = 1,
                    TenDanhMuc = "Thực đơn lớp mầm bữa sáng",
                    GhiChu = "",
                    ThoiGian = "07:30",
                    NangLuong = 100,
                    ChatDam = 20,
                    ChatBeo = 10,
                    ChatBot = 30,
                });

            modelBuilder.Entity<ThucDon>().HasData(
                new ThucDon() { MaThucDon = 1, NgayApDung = new DateTime(2022, 12, 5), NgayTao = new DateTime(2022, 12, 3), MaDanhMuc = 1 });

            modelBuilder.Entity<MonAn>().HasData(
                new MonAn() { MaMonAn = 1, TenMonAn = "Chôm chôm", GhiChu = "", NangLuong = 0, ChatDam = 0, ChatBeo = 0, ChatBot = 0 },
                new MonAn() { MaMonAn = 2, TenMonAn = "Thịt heo nạc xào đậu cô ve", GhiChu = "", NangLuong = 0, ChatDam = 0, ChatBeo = 0, ChatBot = 0 });

            modelBuilder.Entity<MonAnThucPham>().HasData(
                new MonAnThucPham() { MaMonAn = 1, MaThucPham = 1, SoLuong = 0.05 },
                new MonAnThucPham() { MaMonAn = 2, MaThucPham = 3, SoLuong = 0.05 },
                new MonAnThucPham() { MaMonAn = 2, MaThucPham = 2, SoLuong = 0.05 });

            modelBuilder.Entity<ThucDonMonAn>().HasData(
                new ThucDonMonAn() { MaThucDon = 1, MaMonAn = 1, SoLuong = 1 },
                new ThucDonMonAn() { MaThucDon = 1, MaMonAn = 2, SoLuong = 1 });

            modelBuilder.Entity<PhanQuyen>().HasData(
                new PhanQuyen() { MaQuyen = 1, TenQuyen = "Admin", GhiChu = "" }); ;

            modelBuilder.Entity<LoaiNhanSu>().HasData(
                new LoaiNhanSu() { MaLoaiNhanSu = 1, TenLoaiNhanSu = "Cán bộ quản lý", GhiChu = "" });

            modelBuilder.Entity<PhongBan>().HasData(
               new PhongBan() { MaPhongBan = 1, TenPhongBan = "Phòng giáo viên", GhiChu = "" });

            modelBuilder.Entity<NhanSu>().HasData(
               new NhanSu()
               {
                   MaNhanSu = "0",
                   Ho = "Lê Nguyễn Đại Đức",
                   Ten = "Tâm",
                   GioiTinh = "Nam",
                   NgaySinh = new DateTime(2001, 01, 10),
                   NoiSinh = "Long An",
                   CMND = "123456789",
                   NgayCap = null,
                   DanToc = "Kinh",
                   TonGiao = "Không",
                   QuocTich = "Việt Nam",
                   NgayVaoTruong = new DateTime(2020, 01, 10),
                   MaPhongBan = 1,
                   TrangThaiLamViec = "Đang làm",
                   LyDoThoiViec = "",
                   NgayCapNhat = DateTime.Now,
                   MaLoaiNhanSu = 1,
                   MaChucVu = 3,
                   MaKhoiLop = null,
                   SoDienThoai = "123456789",
                   Email = "lenguyenductamcv@gmail.com",
                   HoKhau = "Long An",
                   DiaChi = "Tân Phú",
                   HinhAnh = "",
                   MatKhau = "Admin@123",
                   TrangThaiTaiKhoan = "Kích hoạt",
               });

            modelBuilder.Entity<NhanSuPhanQuyen>().HasData(
              new NhanSuPhanQuyen() { MaNhanSu = "0", MaQuyen = 1 });
        }
    }
}