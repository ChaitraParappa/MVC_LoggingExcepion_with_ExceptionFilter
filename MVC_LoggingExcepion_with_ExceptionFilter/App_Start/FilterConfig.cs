using MVC_LoggingExcepion_with_ExceptionFilter.CustomFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_LoggingExcepion_with_ExceptionFilter.App_Start
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new ExceptionHandlerAttribute());
		}
	}
}