using PowerPuffBoys.SWKOM.Package.Services.Interfaces;
using PowerPuffBoys.SWKOM.BusinessLogic.Entities;
using FluentValidation;

namespace PowerPuffBoys.SWKOM.BusinessLogic
{
    public class TransferwarehouseLogic : ITransferwarehouseLogic
    {
    }

    public class TransferwarehouseValidatior : AbstractValidator<Transferwarehouse>
    {
        public TransferwarehouseValidatior()
        {
        }
    }
}
