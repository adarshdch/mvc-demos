using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialUsingAjaxDemo.Models
{
	public class Incident
	{
		public int ID { get; set; }

		public string Title { get; set; }

		public bool IsPublic { get; set; }
	}
}