﻿using System.Web;
using System.Web.Mvc;

namespace Online_Medicine_Shopping
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}