using AutoMapper;
using TruongMamNon.BackendApi.Data.Entities;
using TruongMamNon.BackendApi.ViewModels.HeThong;
using TruongMamNon.BackendApi.ViewModels.MamNon;

namespace TruongMamNon.BackendApi.Helpers
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            CreateMap<DanhMucThucDon, DanhMucThucDonVm>().ReverseMap();
            CreateMap<NienHoc, NienHocVm>().ReverseMap();
        }
    }
}