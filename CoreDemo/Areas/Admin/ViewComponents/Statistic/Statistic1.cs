﻿using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CoreDemo.Areas.Admin.ViewComponents.Statistic
{
	public class Statistic1 : ViewComponent
	{
		BlogManager bm = new BlogManager(new EfBlogRepository());
		Context c = new Context();
		public IViewComponentResult Invoke()
		{
			ViewBag.v1 = bm.GetList().Count();
			ViewBag.v2 = c.Contacts.Count();
			ViewBag.v3 = c.Comments.Count();

			string api = "d9e1c81cad735ce0a83a1450fed8e7b0";
			string connection = "https://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid=" + api;

			XDocument document = XDocument.Load(connection);
			ViewBag.v4 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
			return View();
		}
	}
}
