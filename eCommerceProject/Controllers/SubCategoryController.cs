﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace eCommerceProject.Controllers
{
	public class SubCategoryController : Controller
	{
		SubCategoryManager scm=new SubCategoryManager(new EfSubCategoryRepository());	  
		public IActionResult Index(int id)
		{
			ViewBag.i = id;	
			var values = scm.TGetList(id);
			return View(values);
		}
	}
}
