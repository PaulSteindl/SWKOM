using PowerPuffBoys.SWKOM.Package.Services.Interfaces;
using PowerPuffBoys.SWKOM.BusinessLogic.Entities;
using FluentValidation;

namespace PowerPuffBoys.SWKOM.BusinessLogic
{
    public class HopArrivalLogic : IHopArrival
    {
    }

    public class HopArrivalValidatior : AbstractValidator<HopArrival>
    {
        public HopArrivalValidatior()
        {
            RuleFor(x => x.Code).Matches("^[A-Z]{4}\\d{1,4}$");
        }
    }
}
