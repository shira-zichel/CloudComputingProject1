using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BE;
using CloudComputingProject1.Models;

namespace CloudComputingProject1.Controllers
{
    public class PrescriptionController : Controller
    {
        public BL.ImplementBL bl = new BL.ImplementBL();
        public ActionResult PrescriptionsList()
        {

            PrescriptionModel model = new PrescriptionModel();
            List<Prescription> lists = model.GetAllPrescriptions();

            //List <Prescription> PrescriptionsList = new List<Prescription>();
            //try
            //{
            //    PrescriptionsList = bl.getAllPrescriptions().ToList();
            //}
            //catch (Exception ex)
            //{
            //    ViewBag.Message = String.Format(ex.Message);
            //    return View("LoginAdministratorBtn");
            //}
            return View("PrescriptionsList", lists);
        }
        public ActionResult PrescriptionsById(int Id)
        {
            //פונקציה שמחזירה את הרשימה של המרשמים של הפציינט לפי הת.ז
           // List<Prescription> PrescriptionList = bl.PatientPrescriptions(Id);
            PrescriptionAndListOfPrescriptions p = new PrescriptionAndListOfPrescriptions();
            return View("AddPrescription", p);
        }
        public ActionResult CreatePrescription(Prescription p)
        {
            try
            {
                //bl.AddPrescription(p);
            }
            catch (Exception ex)
            {
                ViewBag.Message = String.Format(ex.Message);
                return View("AddPrescription");

            }
            ViewBag.Message = String.Format("The prescription was created successfully");

            return View("AddPrescription", new PrescriptionAndListOfPrescriptions());
        }
    }
}
