using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adını Boş Bırakamazsınız");
            RuleFor(x => x.WriterSurName).NotEmpty().WithMessage("Yazar soyadını Boş Bırakamazsınız");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Yazar soyadını Boş Bırakamazsınız");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Yazar ünvanı Boş Bırakamazsınız");

            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("En az 2 karakter girişi yapınız");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("En fazla 50 karakter girişi yapınız");

            RuleFor(x => x.WriterSurName).MinimumLength(2).WithMessage("En az 2 karakter girişi yapınız");
            RuleFor(x => x.WriterSurName).MaximumLength(50).WithMessage("En fazla 50 karakter girişi yapınız");

            RuleFor(x => x.WriterAbout).MinimumLength(10).WithMessage("En az 10 karakter girişi yapınız");
            RuleFor(x => x.WriterAbout).MaximumLength(100).WithMessage("En fazla 100 karakter girişi yapınız");

            RuleFor(x => x.WriterTitle).MinimumLength(2).WithMessage("En az 2 karakter girişi yapınız");
            RuleFor(x => x.WriterTitle).MaximumLength(50).WithMessage("En fazla 50 karakter girişi yapınız");

            RuleFor(x => x.WriterMail).MinimumLength(10).WithMessage("En az 10 karakter girişi yapınız");
            RuleFor(x => x.WriterMail).MaximumLength(50).WithMessage("En fazla 50 karakter girişi yapınız");
        }
    }
}
