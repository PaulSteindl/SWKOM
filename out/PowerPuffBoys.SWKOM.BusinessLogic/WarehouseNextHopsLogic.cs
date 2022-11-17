using PowerPuffBoys.SWKOM.Package.Services.Interfaces;
using PowerPuffBoys.SWKOM.BusinessLogic.Entities;
using FluentValidation;

namespace PowerPuffBoys.SWKOM.BusinessLogic
{
    public class WarehouseNextHopsLogic : IWarehouseNextHopsLogic
    {
    }

    public class WarehouseNextHopsValidatior : AbstractValidator<WarehouseNextHops>
    {
        public WarehouseNextHopsValidatior()
        {
            RuleFor(x => x.Hop).NotNull();
        }
    }
}