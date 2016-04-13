using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartialUsingAjaxDemo.Models;

namespace PartialUsingAjaxDemo.Controllers
{
		public class HomeController : Controller
		{
				// GET: Home
				public ActionResult Index()
				{
						return View(StaticData.Report);
				}

				[HttpGet]
		public ActionResult CreateIncident()
		{
			return PartialView("_CreateIncident");
		}

		[HttpPost]
		public ActionResult CreateIncident(Incident incident)
		{
			incident.ID = StaticData.Report.Incidents.Count() + 1;
			StaticData.Report.Incidents.Add(incident);
			return PartialView("_ListIncidents", StaticData.Report.Incidents);
		}

			
		}
}