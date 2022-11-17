using PowerPuffBoys.SWKOM.Package.Services.Interfaces;
using PowerPuffBoys.SWKOM.BusinessLogic.Entities;
using FluentValidation;

namespace PowerPuffBoys.SWKOM.BusinessLogic
{
    public class RecipientLogic : IRecipientLogic
    {

    }

    public class RecipientValidatior : AbstractValidator<Recipient>
    {
        public RecipientValidatior()
        {
            RuleFor(x => x.PostalCode).Matches("^[A]\\-[0-9][0-9][0-9][0-9]$").When(x => x.Country == "Austria" || x.Country == "Österreich");
            RuleFor(x => x.Street).Matches("^[A-Za-zß][A-Za-zß]*\\s[1-9]+[a-z]?\\/?.*$").When(x => x.Country == "Austria" || x.Country == "Österreich");
            RuleFor(x => x.City).Matches("^[A-Z][A-za-z\\-\\/\\sß]*$").When(x => x.Country == "Austria" || x.Country == "Österreich");
        }
    }
}
