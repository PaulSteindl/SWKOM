using PowerPuffBoys.SWKOM.Package.Services.Interfaces;
using PowerPuffBoys.SWKOM.BusinessLogic.Entities;
using FluentValidation;

namespace PowerPuffBoys.SWKOM.BusinessLogic
{
    public class ParcelLogic : IParcelLogic
    {
    }

    public class ParcelValidator : AbstractValidator<Parcel>
    {
        public ParcelValidator()
        {
            RuleFor(x => x.TrackingId).Matches("^[A - Z0 - 9]{ 9}$");
            RuleFor(x => x.Weight).GreaterThanOrEqualTo(0.0f);
            RuleFor(x => x.Recipient).NotNull();
            RuleFor(x => x.Sender).NotNull();
            RuleFor(x => x.State).NotNull();
            RuleFor(x => x.VisitedHops).NotNull();
            RuleFor(x => x.FutureHops).NotNull();
        }
    }
}
