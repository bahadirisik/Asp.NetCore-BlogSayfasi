using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.Writer
{
	public class WriterAboutOnDashboard : ViewComponent
	{
		WriterManager wm = new WriterManager(new EfWriterRepository());

		Context c = new Context();
		public IViewComponentResult Invoke()
		{
			//var userMail = User.Identity.Name;
			//var writerId = c.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterID).FirstOrDefault();
		
			var values = wm.GetWriterById((int)HttpContext.Session.GetInt32("userid"));
			return View(values);
		}
	}
}
