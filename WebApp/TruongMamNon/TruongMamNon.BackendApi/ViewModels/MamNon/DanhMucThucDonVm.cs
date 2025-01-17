﻿using TruongMamNon.BackendApi.Data.Entities;

namespace TruongMamNon.BackendApi.ViewModels.MamNon
{
    public class DanhMucThucDonVm
    {
        public int MaDanhMuc { get; set; }
        public string TenDanhMuc { get; set; }
        public string GhiChu { get; set; }
        public string ThoiGian { get; set; }
        public double NangLuong { get; set; }
        public double ChatDam { get; set; }
        public double ChatBeo { get; set; }
        public double ChatBot { get; set; }
    }
}