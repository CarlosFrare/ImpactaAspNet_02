﻿using Loja.MVC.Filtros;
using System.Web;
using System.Web.Mvc;

namespace Loja.MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new LogErrorFilter());

            /*filters.Add(new HandleErrorAttribute());*/
        }
    }
}
