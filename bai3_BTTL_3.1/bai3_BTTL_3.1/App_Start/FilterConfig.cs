﻿using System.Web;
using System.Web.Mvc;

namespace bai3_BTTL_3._1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
