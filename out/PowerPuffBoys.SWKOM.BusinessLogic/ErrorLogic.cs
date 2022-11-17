using PowerPuffBoys.SWKOM.Package.Services.Interfaces;
using PowerPuffBoys.SWKOM.BusinessLogic.Entities;
using FluentValidation;

namespace PowerPuffBoys.SWKOM.BusinessLogic
{
    public class ErrorLogic : IErrorLogic
    {
    }

    public class ErrorValidatior : AbstractValidator<Error>
    {
        public ErrorValidatior()
        {
        }
    }
}
