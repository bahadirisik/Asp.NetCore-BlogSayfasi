using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Models
{
	public class UserSignUpViewModel
	{
		[Display(Name = "Ad Soyad")]
		[Required(ErrorMessage ="Ad Soyad Giriniz")]
		public string NameSurname { get; set; }

		[Display(Name = "Şifre")]
		[Required(ErrorMessage = "Şifre Giriniz")]
		public string Password { get; set; }

		[Display(Name = "Şifre Tekrarla")]
		[Compare("Password", ErrorMessage ="Şifreler Uyuşmuyor")]
		public string ConfirmPassword { get; set; }

		[Display(Name = "Mail")]
		[Required(ErrorMessage = "Mail Giriniz")]
		public string Mail { get; set; }

		[Display(Name = "Kullanıcı Adı")]
		[Required(ErrorMessage = "Kullanıcı Adı Giriniz")]
		public string UserName { get; set; }

		[Display(Name = "Kullanım Koşulu")]
		[Required(ErrorMessage = "Kullanım Koşulunu Kabul Etmeniz Gerekir")]
		public bool IsAgreedWithTerms { get; set; }
	}
}
