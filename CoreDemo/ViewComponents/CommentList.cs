﻿using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents
{
	public class CommentList : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var commentvalues = new List<UserComment>
			{
				new UserComment
				{
					ID=1,
					UserName="Bahadır"
				},
				new UserComment
				{
					ID=2,
					UserName="Mehmet"
				},
				new UserComment
				{
					ID=3,
					UserName="Ali"
				}
			};
			return View(commentvalues);
		}
	}
}
