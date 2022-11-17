using PowerPuffBoys.SWKOM.Package.Services.Interfaces;
using PowerPuffBoys.SWKOM.BusinessLogic.Entities;
using FluentValidation;

namespace PowerPuffBoys.SWKOM.BusinessLogic
{
    public class GeoCoordinateLogic : IGeoCoordinateLogic
    {
    }

    public class GeoCoordinateValidatior : AbstractValidator<GeoCoordinate>
    {
        public GeoCoordinateValidatior()
        {
        }
    }
}
