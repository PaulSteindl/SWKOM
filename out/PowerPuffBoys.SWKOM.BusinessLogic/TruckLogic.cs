using PowerPuffBoys.SWKOM.Package.Services.Interfaces;
using PowerPuffBoys.SWKOM.BusinessLogic.Entities;
using FluentValidation;

namespace PowerPuffBoys.SWKOM.BusinessLogic
{
    public class TruckLogic : ITruckLogic
    {
    }

    public class TruckValidatior : AbstractValidator<Truck>
    {
        public TruckValidatior()
        {
        }
    }
}
