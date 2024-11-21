using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class WriterValidator : AbstractValidator<Writer>
	{
		public WriterValidator()
		{
			RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adı soyadı kısmı boş geçilemez");
			RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail adresi boş geçilemez");
			RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre boş geçilemez")
				.Matches(@"[a-z]+").WithMessage("En az bir küçük karakter kullanın")
				.Matches(@"[A-Z]+").WithMessage("En az bir büyük karakter kullanın")
				.Matches(@"[0-9]+").WithMessage("En az bir sayı kullanın")
				.Matches(@"[\!\?\*\.]+").WithMessage("En az bir özel karakter kullanın");
			RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("En az 2 karakter kullanın");
			RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("En fazla 50 karakter kullanın");
			RuleFor(x => x.WriterPassword).Equal(y => y.WriterConfirmPassword).WithMessage("Aynı şifreyi girmelisiniz");
		}
	}
}
