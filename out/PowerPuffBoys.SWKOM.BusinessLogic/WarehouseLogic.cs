using PowerPuffBoys.SWKOM.Package.Services.Interfaces;
using PowerPuffBoys.SWKOM.BusinessLogic.Entities;
using FluentValidation;

namespace PowerPuffBoys.SWKOM.BusinessLogic
{
    public class WarehouseLogic : IWarehouseLogic
    {
    }

    public class WarehouseValidatior : AbstractValidator<Warehouse>
    {
        public WarehouseValidatior()
        {
            RuleFor(x => x.Description).Matches("^[A-Za-zß\\-\\/\\s1-9]+$");
            RuleFor(x => x.NextHops).NotNull();
        }
    }
}
