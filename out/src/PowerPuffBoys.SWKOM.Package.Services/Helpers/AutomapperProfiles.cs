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

            CreateMap<Business.Error, DTO.Error>();
            CreateMap<Business.GeoCoordinate, DTO.GeoCoordinate>();
            CreateMap<Business.Hop, DTO.Hop>();
            CreateMap<Business.HopArrival, DTO.HopArrival>();
            // CreateMap<Business.Parcel, DTO.Parcel>(); // komplexer wegen mult. dto -> 1 business
            CreateMap<Business.Recipient, DTO.Recipient>();
            CreateMap<Business.Transferwarehouse, DTO.Transferwarehouse>();
            CreateMap<Business.Truck, DTO.Truck>();
            CreateMap<Business.Warehouse, DTO.Warehouse>();
            CreateMap<Business.WarehouseNextHops, DTO.WarehouseNextHops>();
        }
    }
}
