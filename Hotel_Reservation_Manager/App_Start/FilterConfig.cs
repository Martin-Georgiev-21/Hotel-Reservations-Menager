﻿using System.Web;
using System.Web.Mvc;

namespace Hotel_Reservation_Manager
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}