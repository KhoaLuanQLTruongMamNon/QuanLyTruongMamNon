using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TruongMamNon.BackendApi.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ChucVus",
                columns: new[] { "MaChucVu", "GhiChu", "TenChucVu" },
                values: new object[,]
                {
                    { 1, "", "Hiệu trưởng" },
                    { 2, "", "Phó hiệu trưởng" },
                    { 3, "", "Trưởng phòng" },
                    { 4, "", "Phó trưởng phòng" },
                    { 5, "", "Nhân viên" },
                    { 6, "", "Giáo viên" }
                });

            migrationBuilder.InsertData(
                table: "DanhMucThucDons",
                columns: new[] { "MaDanhMuc", "ChatBeo", "ChatBot", "ChatDam", "GhiChu", "NangLuong", "TenDanhMuc", "ThoiGian" },
                values: new object[] { 1, 10.0, 30.0, 20.0, "", 100.0, "Thực đơn lớp mầm bữa sáng", "07:30" });

            migrationBuilder.InsertData(
                table: "DanhMucThucPhams",
                columns: new[] { "MaDanhMuc", "GhiChu", "TenDanhMuc" },
                values: new object[,]
                {
                    { 1, "", "Ngũ cốc" },
                    { 2, "", "Thịt và các sản phẩm từ thịt" },
                    { 3, "", "Thủy sản và sản phẩm thủy sản" },
                    { 4, "", "Rau, củ, quả và sản phẩm rau, củ, quả" },
                    { 5, "", "Trứng và các sản phẩm từ trứng" },
                    { 6, "", "Sữa tươi nguyên liệu" },
                    { 7, "", "Mật ong và các sản phẩm từ mật ong" },
                    { 8, "", "Gia vị" },
                    { 9, "", "Thực phẩm khác" }
                });

            migrationBuilder.InsertData(
                table: "KhoiLops",
                columns: new[] { "MaKhoiLop", "GhiChu", "TenKhoiLop" },
                values: new object[,]
                {
                    { 1, "", "3-12 tháng - KL0312" },
                    { 2, "", "25-36 tháng - KL2536" },
                    { 3, "", "13-24 tháng - KL1324" },
                    { 4, "", "3-4 tuổi - KLM" },
                    { 5, "", "4-5 tuổi - KLC" },
                    { 6, "", "5-6 tuổi - KLL" }
                });

            migrationBuilder.InsertData(
                table: "LoaiNhanSus",
                columns: new[] { "MaLoaiNhanSu", "GhiChu", "TenLoaiNhanSu" },
                values: new object[] { 1, "", "Cán bộ quản lý" });

            migrationBuilder.InsertData(
                table: "MonAns",
                columns: new[] { "MaMonAn", "ChatBeo", "ChatBot", "ChatDam", "GhiChu", "NangLuong", "TenMonAn" },
                values: new object[,]
                {
                    { 1, 0.0, 0.0, 0.0, "", 0.0, "Chôm chôm" },
                    { 2, 0.0, 0.0, 0.0, "", 0.0, "Thịt heo nạc xào đậu cô ve" }
                });

            migrationBuilder.InsertData(
                table: "NienHocs",
                columns: new[] { "MaNienHoc", "BatDauHK1", "BatDauHK2", "KetThucHK1", "KetThucHK2", "TenNienHoc" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Năm học 2019-2020" },
                    { 2, new DateTime(2020, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Năm học 2020-2021" },
                    { 3, new DateTime(2021, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Năm học 2021-2022" },
                    { 4, new DateTime(2022, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Năm học 2022-2023" }
                });

            migrationBuilder.InsertData(
                table: "PhanQuyens",
                columns: new[] { "MaQuyen", "GhiChu", "TenQuyen" },
                values: new object[] { 1, "", "Admin" });

            migrationBuilder.InsertData(
                table: "PhongBans",
                columns: new[] { "MaPhongBan", "GhiChu", "TenPhongBan" },
                values: new object[] { 1, "", "Phòng giáo viên" });

            migrationBuilder.InsertData(
                table: "LopHocs",
                columns: new[] { "MaLop", "HocPhi", "MaKhoiLop", "MaNienHoc", "SiSoToiDa", "TenLop" },
                values: new object[,]
                {
                    { 1, 0m, 4, 4, 80, "Lớp mầm 1" },
                    { 2, 0m, 4, 4, 80, "Lớp mầm 2" },
                    { 3, 0m, 4, 4, 80, "Lớp mầm 3" }
                });

            migrationBuilder.InsertData(
                table: "NhanSus",
                columns: new[] { "MaNhanSu", "CMND", "DanToc", "DiaChi", "Email", "GioiTinh", "HinhAnh", "Ho", "HoKhau", "LyDoThoiViec", "MaChucVu", "MaKhoiLop", "MaLoaiNhanSu", "MaPhongBan", "MatKhau", "NgayCap", "NgayCapNhat", "NgaySinh", "NgayVaoTruong", "NoiSinh", "QuocTich", "SoDienThoai", "Ten", "TonGiao", "TrangThaiLamViec", "TrangThaiTaiKhoan" },
                values: new object[] { "0", "123456789", "Kinh", "Tân Phú", "lenguyenductamcv@gmail.com", "Nam", "", "Lê Nguyễn Đại Đức", "Long An", "", 3, null, 1, 1, "Admin@123", null, new DateTime(2022, 12, 3, 21, 10, 27, 374, DateTimeKind.Local).AddTicks(778), new DateTime(2001, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Long An", "Việt Nam", "123456789", "Tâm", "Không", "Đang làm", "Kích hoạt" });

            migrationBuilder.InsertData(
                table: "ThucDons",
                columns: new[] { "MaThucDon", "MaDanhMuc", "NgayApDung", "NgayTao" },
                values: new object[] { 1, 1, new DateTime(2022, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "ThucPhams",
                columns: new[] { "MaThucPham", "ChatBeo", "ChatBot", "ChatDam", "DonViTinh", "HinhAnh", "MaDanhMuc", "NangLuong", "TenThucPham", "TonKho" },
                values: new object[,]
                {
                    { 1, 0.0, 16400.0, 1500.0, "Kg", "", 4, 72000.0, "Chôm chôm", 0.0 },
                    { 2, 1000.0, 11000.0, 5000.0, "Kg", "", 4, 73000.0, "Đậu cô ve", 0.0 },
                    { 3, 7000.0, 0.0, 19000.0, "Kg", "", 2, 139000.0, "Thịt heo nạc", 0.0 },
                    { 4, 0.0, 11000.0, 900.0, "Kg", "", 4, 48000.0, "Nhãn", 0.0 }
                });

            migrationBuilder.InsertData(
                table: "HocSinhs",
                columns: new[] { "MaHocSinh", "CMNDPhuHuynh", "DanToc", "DiaChi", "DiaChiPhuHuynh", "EmailPhuHuynh", "GhiChu", "GioiTinh", "HinhAnh", "Ho", "HoKhau", "HoTenPhuHuynh", "LyDoNghiHoc", "MaKhoiLop", "MaLopHoc", "MatKhau", "NamSinhPhuHuynh", "NgayCapNhat", "NgayNhapHoc", "NgaySinh", "NgheNghiepPhuHuynh", "NoiSinh", "QuocTich", "SDTPhuHuynh", "Ten", "TonGiao", "TrangThaiHoc", "TrangThaiTaiKhoan" },
                values: new object[] { "0", "012345678910", "Kinh", "HCM", "140 Lê trọng tấn", "lenguyenductamht@gmail.com", "", "Nam", "", "Lê Nguyễn Đại Đức", "Long An", "Lê Huỳnh Nam", "", 4, 1, "Client@123", new DateTime(1968, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 3, 21, 10, 27, 374, DateTimeKind.Local).AddTicks(611), new DateTime(2022, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2001, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tự do", "Long An", "Việt Nam", "0123456789", "Tâm", "Không", "Đang học", "Kích hoạt" });

            migrationBuilder.InsertData(
                table: "MonAnThucPhams",
                columns: new[] { "MaMonAn", "MaThucPham", "SoLuong" },
                values: new object[,]
                {
                    { 1, 1, 0.050000000000000003 },
                    { 2, 2, 0.050000000000000003 },
                    { 2, 3, 0.050000000000000003 }
                });

            migrationBuilder.InsertData(
                table: "NhanSuPhanQuyens",
                columns: new[] { "MaNhanSu", "MaQuyen" },
                values: new object[] { "0", 1 });

            migrationBuilder.InsertData(
                table: "ThucDonMonAns",
                columns: new[] { "MaMonAn", "MaThucDon", "SoLuong" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ChucVus",
                keyColumn: "MaChucVu",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ChucVus",
                keyColumn: "MaChucVu",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ChucVus",
                keyColumn: "MaChucVu",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ChucVus",
                keyColumn: "MaChucVu",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ChucVus",
                keyColumn: "MaChucVu",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "DanhMucThucPhams",
                keyColumn: "MaDanhMuc",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DanhMucThucPhams",
                keyColumn: "MaDanhMuc",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DanhMucThucPhams",
                keyColumn: "MaDanhMuc",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DanhMucThucPhams",
                keyColumn: "MaDanhMuc",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "DanhMucThucPhams",
                keyColumn: "MaDanhMuc",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "DanhMucThucPhams",
                keyColumn: "MaDanhMuc",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "DanhMucThucPhams",
                keyColumn: "MaDanhMuc",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "HocSinhs",
                keyColumn: "MaHocSinh",
                keyValue: "0");

            migrationBuilder.DeleteData(
                table: "KhoiLops",
                keyColumn: "MaKhoiLop",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "KhoiLops",
                keyColumn: "MaKhoiLop",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "KhoiLops",
                keyColumn: "MaKhoiLop",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "KhoiLops",
                keyColumn: "MaKhoiLop",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "KhoiLops",
                keyColumn: "MaKhoiLop",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "LopHocs",
                keyColumn: "MaLop",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LopHocs",
                keyColumn: "MaLop",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MonAnThucPhams",
                keyColumns: new[] { "MaMonAn", "MaThucPham" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "MonAnThucPhams",
                keyColumns: new[] { "MaMonAn", "MaThucPham" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "MonAnThucPhams",
                keyColumns: new[] { "MaMonAn", "MaThucPham" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "NhanSuPhanQuyens",
                keyColumns: new[] { "MaNhanSu", "MaQuyen" },
                keyValues: new object[] { "0", 1 });

            migrationBuilder.DeleteData(
                table: "NienHocs",
                keyColumn: "MaNienHoc",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "NienHocs",
                keyColumn: "MaNienHoc",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "NienHocs",
                keyColumn: "MaNienHoc",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ThucDonMonAns",
                keyColumns: new[] { "MaMonAn", "MaThucDon" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ThucDonMonAns",
                keyColumns: new[] { "MaMonAn", "MaThucDon" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "ThucPhams",
                keyColumn: "MaThucPham",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "LopHocs",
                keyColumn: "MaLop",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MonAns",
                keyColumn: "MaMonAn",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MonAns",
                keyColumn: "MaMonAn",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "NhanSus",
                keyColumn: "MaNhanSu",
                keyValue: "0");

            migrationBuilder.DeleteData(
                table: "PhanQuyens",
                keyColumn: "MaQuyen",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ThucDons",
                keyColumn: "MaThucDon",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ThucPhams",
                keyColumn: "MaThucPham",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ThucPhams",
                keyColumn: "MaThucPham",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ThucPhams",
                keyColumn: "MaThucPham",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ChucVus",
                keyColumn: "MaChucVu",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DanhMucThucDons",
                keyColumn: "MaDanhMuc",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DanhMucThucPhams",
                keyColumn: "MaDanhMuc",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DanhMucThucPhams",
                keyColumn: "MaDanhMuc",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "KhoiLops",
                keyColumn: "MaKhoiLop",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "LoaiNhanSus",
                keyColumn: "MaLoaiNhanSu",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "NienHocs",
                keyColumn: "MaNienHoc",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PhongBans",
                keyColumn: "MaPhongBan",
                keyValue: 1);
        }
    }
}
