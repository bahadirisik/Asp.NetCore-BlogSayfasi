﻿using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using CoreDemo.Models;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
	public class WriterController : Controller
	{
		WriterManager wm = new WriterManager(new EfWriterRepository());

		[Authorize]
		public IActionResult Index()
		{
			var userMail = User.Identity.Name;
			ViewBag.v = userMail;
			Context c = new Context();
			var writerName = c.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterName).FirstOrDefault();
			ViewBag.v2 = writerName;
			return View();
		}

		public IActionResult WriterProfile()
		{
			return View();
		}

		[AllowAnonymous]
		public IActionResult Test()
		{
			return View();
		}

		[AllowAnonymous]
		public PartialViewResult WriterNavbarPartial()
		{
			return PartialView();
		}

		[AllowAnonymous]
		public PartialViewResult WriterFooterPartial()
		{
			return PartialView();
		}


		[HttpGet]
		public IActionResult WriterEditProfile()
		{
			var writervalues = wm.TGetById((int)HttpContext.Session.GetInt32("userid"));
			return View(writervalues);
		}

		[HttpPost]
		public IActionResult WriterEditProfile(Writer p)
		{
			WriterValidator wl = new WriterValidator();
			ValidationResult results = wl.Validate(p);
			if (results.IsValid)
			{
				wm.TUpdate(p);
				return RedirectToAction("Index", "Dashboard");
			}
			else
			{
				foreach (var item in results.Errors)
				{
					ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
				}
			}
			return View();
		}

		[AllowAnonymous]
		[HttpGet]
		public IActionResult WriterAdd()
		{
			return View();
		}

		[AllowAnonymous]
		[HttpPost]
		public IActionResult WriterAdd(AddProfileImage p)
		{
			Writer w = new Writer();
			if (p.WriterImage != null)
			{
				var extension = Path.GetExtension(p.WriterImage.FileName);
				var newimagename = Guid.NewGuid() + extension;
				var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImageFiles/", newimagename);
				var stream = new FileStream(location, FileMode.Create);
				p.WriterImage.CopyTo(stream);
				w.WriterImage = newimagename;
			}
			w.WriterMail = p.WriterMail;
			w.WriterName = p.WriterName;
			w.WriterPassword = p.WriterPassword;
			w.WriterConfirmPassword = p.WriterConfirmPassword;
			w.WriterStatus = true;
			w.WriterAbout = p.WriterAbout;

			WriterValidator wl = new WriterValidator();
			ValidationResult results = wl.Validate(w);
			if (results.IsValid)
			{
				wm.TAdd(w);
				return RedirectToAction("Index", "Dashboard");
			}
			else
			{
				foreach (var item in results.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}
			return View();
		}
	}
}
