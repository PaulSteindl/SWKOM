using PowerPuffBoys.SWKOM.Package.Services.Interfaces;
using PowerPuffBoys.SWKOM.BusinessLogic.Entities;
using FluentValidation;

namespace PowerPuffBoys.SWKOM.BusinessLogic
{
    public class HopLogic : IHopLogic
    {
    }

    public class HopValidatior : AbstractValidator<Hop>
    {
        public HopValidatior()
        {
            RuleFor(x => x.LocationCoordinates).NotNull();
        }
    }
}
