using CloudComputingProject1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BE;
namespace CloudComputingProject1.Controllers
{
    public class PatientController : Controller
    {
        public BL.ImplementBL bl = new BL.ImplementBL();
        PatientModel modelPatient = new PatientModel();

        public ActionResult PatientsList()
        {
            //List<Patient> patiensList = new List<Patient>();
            //try
            //{
            //    patiensList = bl.getAllPatients().ToList();
            //}
            //catch (Exception ex)
            //{
            //    ViewBag.Message = String.Format(ex.Message);
            //    return View("LoginAdministratorBtn");
            //}
            //return View(patiensList);
            List<Patient> patiensList = modelPatient.GetAllPatients();


            return View(patiensList);
        }
        public ActionResult CreatePatient()
        {
            return View();
        }

        public ActionResult AddNewPatient(Patient p)
        {
            modelPatient.addPatient(p);
            List<Patient> patiensList = modelPatient.GetAllPatients();


            return View("PatientsList", patiensList);
        }

        public ActionResult SavePatient(Patient p)
        {
            try
            {
                bl.UpdatePatient(p);
            }
            catch (Exception ex)
            {
                ViewBag.Message = String.Format(ex.Message);
                return View("EditPatient", p);
            }

            List<Patient> patiensList = modelPatient.GetAllPatients();
            return View("PatientsList", patiensList);
        }
        public ActionResult DeletePatient(int id)
        {
            try
            {
                Patient p = modelPatient.GetPatient(id);
                bl.deletePatient(p);

            }
            catch (Exception ex)
            {
                ViewBag.Message = String.Format(ex.Message);
            }
            List<Patient> patiensList = modelPatient.GetAllPatients();
            return View("PatientsList", patiensList);
        }

        public ActionResult EditPatient(int id)
        {
            Patient p = modelPatient.GetPatient(id);
            return View(p);
        }

        public ActionResult DetailsPatient(int id)
        {

            Patient p = modelPatient.GetPatient(id);
            return View(p);
        }
    }
}
