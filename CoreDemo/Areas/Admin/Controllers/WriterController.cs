using CoreDemo.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class WriterController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult WriterList()
		{
			var jsonWriters = JsonConvert.SerializeObject(Writers);
			return Json(jsonWriters);
		}

		public IActionResult GetWriterById(int writerId)
		{
			var writer = Writers.FirstOrDefault(x => x.ID == writerId);
			var jsonWriter = JsonConvert.SerializeObject(writer);
			return Json(jsonWriter);
		}

		[HttpPost]
		public IActionResult AddWriter(WriterClass w)
		{
			Writers.Add(w);
			var jsonWriters = JsonConvert.SerializeObject(w);
			return Json(jsonWriters);
		}

		public IActionResult DeleteWriter(int writerId)
		{
			var writer = Writers.FirstOrDefault(x => x.ID == writerId);
			Writers.Remove(writer);
			return Json(writer);
		}

		public IActionResult UpdateWriter(WriterClass w)
		{
			var writer = Writers.FirstOrDefault(x => x.ID == w.ID);
			writer.Name = w.Name;
			var jsonwriter = JsonConvert.SerializeObject(w);
			return Json(jsonwriter);
		}

		public static List<WriterClass> Writers = new List<WriterClass>()
		{
			new WriterClass
			{
				ID = 1,
				Name = "Ayşe"
			},
			new WriterClass
			{
				ID = 2,
				Name = "Mehmet"
			},
			new WriterClass
			{
				ID = 3,
				Name = "Ali"
			}
		};
	}
}
