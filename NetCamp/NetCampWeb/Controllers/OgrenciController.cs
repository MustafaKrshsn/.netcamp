using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCampWeb.Models.Services;

namespace NetCampWeb.Controllers
{
    public class OgrenciController : Controller
    {
        OgrenciServisi servis;

        public OgrenciController(OgrenciServisi _servis)
        {
            servis = _servis;
        }

        public IActionResult List()
        {
            return View(servis.GetList());
        }
    }
}