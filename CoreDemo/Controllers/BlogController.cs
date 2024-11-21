using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
	public class BlogController : Controller
	{
		BlogManager bm = new BlogManager(new EfBlogRepository());
		CategoryManager cm = new CategoryManager(new EfCategoryRepository());
		public IActionResult Index()
		{
			var values = bm.GetBlogListWithCategory();
			return View(values);
		}

		public IActionResult BlogReadAll(int id)
		{
			ViewBag.i = id;
			var value = bm.GetBlogById(id);
			return View(value);
		}

		public IActionResult BlogListByWriter()
		{
			var values = bm.GetListWithCategoryByWriterBm((int)HttpContext.Session.GetInt32("userid"));
			return View(values);
		}

		[HttpGet]
		public IActionResult BlogAdd()
		{
			List<SelectListItem> categorvalues = (from x in cm.GetList()
												  select new SelectListItem
												  {
													  Text = x.CategoryName,
													  Value = x.CategoryID.ToString()
												  }).ToList();
			ViewBag.cv = categorvalues;
			return View();
		}

		[HttpPost]
		public IActionResult BlogAdd([FromForm]Blog p)
		{
			BlogValidator bv = new BlogValidator();
			ValidationResult result = bv.Validate(p);
			if (result.IsValid)
			{
				p.BlogStatus = true;
				p.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
				p.WriterID = (int)HttpContext.Session.GetInt32("userid");
				bm.TAdd(p);
				return RedirectToAction("BlogListByWriter", "Blog");
			}
			else
			{
				foreach (var item in result.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}

			return View();
		}

		public IActionResult DeleteBlog(int id)
		{
			var blogvalue = bm.TGetById(id);
			bm.TDelete(blogvalue);
			return RedirectToAction("BlogListByWriter");
		}

		[HttpGet]
		public IActionResult EditBlog(int id)
		{
			var blogvalue = bm.TGetById(id);

			List<SelectListItem> categorvalues = (from x in cm.GetList()
												  select new SelectListItem
												  {
													  Text = x.CategoryName,
													  Value = x.CategoryID.ToString()
												  }).ToList();
			ViewBag.cv = categorvalues;

			return View(blogvalue);
		}

		[HttpPost]
		public IActionResult EditBlog(Blog p)
		{
			bm.TUpdate(p);
			p.WriterID = (int)HttpContext.Session.GetInt32("userid");
			p.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
			p.BlogStatus = true;

			return RedirectToAction("BlogListByWriter");
		}
	}
}
