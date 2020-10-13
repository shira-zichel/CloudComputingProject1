using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc; 
using BL;
namespace CloudComputingProject1.Controllers
{
    
    public class ShowChartsController : Controller
    {
        ImplementBL bl = new ImplementBL();
        // GET: ShowCharts
        public ActionResult Index()
        {

            int[][] mat = new int[2][];
            mat[0] = new int[7] { 1, 2, 3, 4, 5, 6, 7 };
            mat[1] = new int[7] { 7, 6, 5, 4, 3, 2, 1 };

            return View(mat);

            //int[] values = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            //var count1 = bl.count("Acamol");
            //var count2 = bl.count("Advill");
            //var count3 = bl.count("Nurufen");
            //ViewBag.ChartTitle = "Drug consumption graph";
            ////values.Add(count1);
            ////values.Add(count2);
            ////values.Add(count3);
            //return View(values);
        }

        // GET: ShowCharts/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ShowCharts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShowCharts/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ShowCharts/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ShowCharts/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ShowCharts/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ShowCharts/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
