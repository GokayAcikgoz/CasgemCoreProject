using FluentValidation;
using Pizzapan.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzapan.BusinessLayer.ValidationRules.OurTeamValidatior
{
    public class CreateOurTeamValidator : AbstractValidator<OurTeam>
    {
        public CreateOurTeamValidator() 
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad boş geçilemez");
            RuleFor(x => x.Surnamde).NotEmpty().WithMessage("Soyad boş geçilemez");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık boş geçilemez");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Minimum 2 karakter gir");
            RuleFor(x => x.Title).MaximumLength(30).WithMessage("Maksimum 30 karakter girin");
        }
    }
}
