using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("İsim alanını Boş Bırakamazsınız");
            RuleFor(x => x.UserMail).NotEmpty().WithMessage("Mail alanını Boş Bırakamazsınız");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu alanını Boş Bırakamazsınız");
            RuleFor(x => x.Message).NotEmpty().WithMessage("Mesaj alanını Boş Bırakamazsınız");

            RuleFor(x => x.UserName).MinimumLength(3).WithMessage("En az 3 karakter girişi yapınız");
            RuleFor(x => x.UserName).MaximumLength(50).WithMessage("En fazla 50 karakter girişi yapınız");

            RuleFor(x => x.UserMail).MinimumLength(3).WithMessage("En az 3 karakter girişi yapınız");
            RuleFor(x => x.UserMail).MaximumLength(50).WithMessage("En fazla 50 karakter girişi yapınız");

            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("En az 3 karakter girişi yapınız");
            RuleFor(x => x.Subject).MaximumLength(50).WithMessage("En fazla 50 karakter girişi yapınız");

            RuleFor(x => x.Message).MinimumLength(10).WithMessage("En az 10 karakter girişi yapınız");
            RuleFor(x => x.Message).MaximumLength(750).WithMessage("En fazla 750 karakter girişi yapınız");
        }
    }
}
