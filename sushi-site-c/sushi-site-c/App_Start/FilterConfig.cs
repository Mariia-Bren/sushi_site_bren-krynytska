﻿using System.Web;
using System.Web.Mvc;

namespace sushi_site_c
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}