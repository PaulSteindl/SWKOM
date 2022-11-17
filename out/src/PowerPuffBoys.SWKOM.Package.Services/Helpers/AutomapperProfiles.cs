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
            CreateMap<Business.Hop, DTO.Hop>().ReverseMap();
            CreateMap<Business.HopArrival, DTO.HopArrival>().ReverseMap();
            // CreateMap<Business.Parcel, DTO.Parcel>(); // komplexer wegen mult. dto -> 1 business
            CreateMap<Business.Recipient, DTO.Recipient>().ReverseMap();
            CreateMap<Business.Transferwarehouse, DTO.Transferwarehouse>().ReverseMap();
            CreateMap<Business.Truck, DTO.Truck>().ReverseMap();
            CreateMap<Business.Warehouse, DTO.Warehouse>().ReverseMap();
            CreateMap<Business.WarehouseNextHops, DTO.WarehouseNextHops>().ReverseMap();
        }
    }
}
