using AutoMapper;

using Business = PowerPuffBoys.SWKOM.BusinessLogic.Entities; // source
using DTO = PowerPuffBoys.SWKOM.Package.Services.DTOs; // dtos

namespace PowerPuffBoys.SWKOM.Package.Services.Helpers
{
    public class AutomapperProfiles : Profile
    {
        public AutomapperProfiles()
        {
            // to use mapper for DTO -> when instancing a dto obj.: var dto = mapper.Map<IEnumerable<DTO.x>>(Business.x)

            CreateMap<Business.Error, DTO.Error>().ReverseMap();
            CreateMap<Business.GeoCoordinate, DTO.GeoCoordinate>().ReverseMap();
            CreateMap<Business.HopArrival, DTO.HopArrival>().ReverseMap();
            CreateMap<Business.Recipient, DTO.Recipient>().ReverseMap();
            CreateMap<Business.Transferwarehouse, DTO.Transferwarehouse>().ReverseMap();
            CreateMap<Business.Truck, DTO.Truck>().ReverseMap();
            CreateMap<Business.Hop, DTO.Hop>()
                .Include<Business.Warehouse, DTO.Warehouse>().ReverseMap();
            CreateMap<Business.Warehouse, DTO.Warehouse>().ReverseMap();
            CreateMap<Business.WarehouseNextHops, DTO.WarehouseNextHops>().ReverseMap();

            /* more complex entity mappings */
            // parcel
            CreateMap<Business.Parcel, DTO.Parcel>()
                .ForMember(dest => dest.Recipient, opt => opt.MapFrom(src => src.Recipient))
                .ForMember(dest => dest.Sender, opt => opt.MapFrom(src => src.Sender))
                .ForMember(dest => dest.Weight, opt => opt.MapFrom(src => src.Weight));
            CreateMap<Business.Parcel, DTO.NewParcelInfo>()
                .ForMember(dest => dest.TrackingId, opt => opt.MapFrom(src => src.TrackingId));
            CreateMap<Business.Parcel, DTO.TrackingInformation>()
                .ForMember(dest => dest.State, opt => opt.MapFrom(src => src.State))
                .ForMember(dest => dest.VisitedHops, opt => opt.MapFrom(src => src.VisitedHops))
                .ForMember(dest => dest.FutureHops, opt => opt.MapFrom(src => src.FutureHops));

        }
    }
}
