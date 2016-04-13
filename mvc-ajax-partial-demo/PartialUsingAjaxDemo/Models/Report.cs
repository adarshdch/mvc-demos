using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialUsingAjaxDemo.Models
{
	public class Report
	{
		public IList<Incident> Incidents { get; set; }
	}
}