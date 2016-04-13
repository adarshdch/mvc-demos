using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialUsingAjaxDemo.Models
{
	public static class StaticData
	{
		private static Report _report = null;

		public static Report Report
		{
			get
			{
				if (_report == null)
				{
					_report = new Report()
					{
						Incidents = new List<Incident>()
						{
							new Incident()
							{
								ID = 1,
								Title = "Incident 1",
								IsPublic = true
							},
							new Incident()
							{
								ID = 2,
								Title = "Incident 2",
								IsPublic = false
							}
						}
					};
				}

				return _report;
			}
		}
	}
}