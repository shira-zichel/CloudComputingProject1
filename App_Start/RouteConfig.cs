﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using BE;
using BL;

namespace CloudComputingProject1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            ImplementBL implementBL = new ImplementBL();
            //implementBL.AddPatient(new Patient { FirstName = "shira", ID = "12972", Prescriptions = null });
            //implementBL.addAdministrator(new Administrator { ID = "76533", Password = 123, UserName = "jkl" });
            //implementBL.AddDoctor(new Doctor { age = 45, ID = "465868", Name = "shi", WorkPlace = "ghj", });
            IEnumerable<Patient> d=   implementBL.getAllPatients();
            Patient f = implementBL.GetPatient("1297");
           implementBL.isAdministrator("12345");
            
            
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
