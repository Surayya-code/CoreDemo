using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.ValidationRules
{
   public class WriterValidator: AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Ad və soyad boş ola bilməz!");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Email boş ola bilməz!");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifrə boş ola bilməz!");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Ən az iki xarakter yazın!");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Ən çox əlli xarakter yaza bilərsiz!");
        }
    }
}
