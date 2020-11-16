using System;
using System.Collections.Generic;
using JubicApiChallenge_Core.Models;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace JubicApiChallenge_Core.Controllers
{
    public class LicenseController : Controller
    {
        //GET: api/license
        public ActionResult Index()
        {
            LicenseContext context = HttpContext.RequestServices.GetService(typeof(LicenseContext)) as LicenseContext;
            List<License> list = context.GetAllLicenses();

            return View(list);
        }

        //GET: api/license/5
        public ActionResult license(int id)
        {
            return View();
        }

    }
}