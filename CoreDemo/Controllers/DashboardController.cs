﻿using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
	public class DashboardController : Controller
	{
		public IActionResult Index()
		{
			Context c = new Context();
			ViewBag.v1 = c.Blogs.Count();
			ViewBag.v2 = c.Blogs.Where(x => x.WriterID == (int)HttpContext.Session.GetInt32("userid")).Count();
			ViewBag.v3 = c.Categories.Count();
			return View();
		}
	}
}
