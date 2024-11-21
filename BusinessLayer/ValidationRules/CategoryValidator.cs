using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class CategoryValidator : AbstractValidator<Category>
	{
		public CategoryValidator()
		{
			RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori İsmi Boş Geçilemez");
			RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Blog Açıklaması Boş Geçilemez");
			RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("İsim 20 Karakteri Geçemez");
			RuleFor(x => x.CategoryName).MinimumLength(2).WithMessage("İsim 2 Karakterden Az Olamaz");
		}
	}
}
