using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BE;
using BL;
using CloudComputingProject1.Models;

namespace CloudComputingProject1.Controllers
{
    public class PrescriptionController : Controller
    {
        public BL.ImplementBL bl = new BL.ImplementBL();
        public ActionResult PrescriptionsList()
        {
            BL.ImplementBL bl = new BL.ImplementBL();
            List<Prescription> PrescriptionsList = new List<Prescription>();
            try
            {
                PrescriptionsList = bl.getAllPrescriptions().ToList();
            }
            catch (Exception ex)
            {
                ViewBag.Message = String.Format(ex.Message);
                return View("LoginAdministratorBtn", "Home");
            }
            return View("PrescriptionsList", PrescriptionsList);
        }
        public ActionResult PrescriptionsById(int Id)
        {
            BL.ImplementBL bl = new BL.ImplementBL();
            List<Prescription> PrescriptionList = new List<Prescription>();
            //פונקציה שמחזירה את הרשימה של המרשמים של הפציינט לפי הת.ז
            try
            {
                PrescriptionList = bl.PatientPrescriptions(Id.ToString()).ToList();
            }
            catch
            {
            }
            PrescriptionAndListOfPrescriptions p = new PrescriptionAndListOfPrescriptions();
            p.prescriptionsList = PrescriptionList;
            return View("AddPrescription", p);
        }
        public ActionResult CreatePrescription(Prescription p)
        {
            BL.ImplementBL bl = new BL.ImplementBL();
            try
            {
                bl.AddPrescription(p);
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
