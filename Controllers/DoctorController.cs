using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BE;
using CloudComputingProject1.Models;

namespace CloudComputingProject1.Controllers
{
    public class DoctorController : Controller
    {
        public BL.ImplementBL bl = new BL.ImplementBL();
        DoctorModel modelDoctor = new DoctorModel();
        //    // GET: Doctor
        //    public ActionResult Index()
        //    {
        //        return View();
        //    }

        //    // GET: Doctor/Details/5
        //    public ActionResult Details(int id)
        //    {
        //        return View();
        //    }

        //    // GET: Doctor/Create
        //    public ActionResult Create()
        //    {
        //        return View();
        //    }

        //    // POST: Doctor/Create
        //    [HttpPost]
        //    public ActionResult Create(FormCollection collection)
        //    {
        //        try
        //        {
        //            // TODO: Add insert logic here

        //            return RedirectToAction("Index");
        //        }
        //        catch
        //        {
        //            return View();
        //        }
        //    }

        //    // GET: Doctor/Edit/5
        //    public ActionResult Edit(int id)
        //    {
        //        return View();
        //    }

        //    // POST: Doctor/Edit/5
        //    [HttpPost]
        //    public ActionResult Edit(int id, FormCollection collection)
        //    {
        //        try
        //        {
        //            // TODO: Add update logic here

        //            return RedirectToAction("Index");
        //        }
        //        catch
        //        {
        //            return View();
        //        }
        //    }

        //    // GET: Doctor/Delete/5
        //    public ActionResult Delete(int id)
        //    {
        //        return View();
        //    }

        //    // POST: Doctor/Delete/5
        //    [HttpPost]
        //    public ActionResult Delete(int id, FormCollection collection)
        //    {
        //        try
        //        {
        //            // TODO: Add delete logic here

        //            return RedirectToAction("Index");
        //        }
        //        catch
        //        {
        //            return View();
        //        }
        //    }
        public ActionResult LogInDoctor()
        {
            return View();
        }
        public ActionResult PrescriptionsById(int Id)
        {
            //פונקציה שמחזירה את הרשימה של המרשמים של הפציינט לפי הת.ז
            //List<Prescription> PrescriptionList= bl.PatientPrescriptions(Id);
            PrescriptionAndListOfPrescriptions p = new PrescriptionAndListOfPrescriptions();
            return View("AddPrescription","Prescription", p);
        }
        public ActionResult LogInDoctorBtn(int Id)
       {
            try
            {
                // bl.ExistDoctor(Id);

            }
            catch (Exception ex)
            {
                ViewBag.Message = String.Format(ex.Message);
                return View("LogInDoctor");

            }
            return View("DoctorEnterPatientsId");
        }
        public ActionResult AddPrescription()
        {
            return View();
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


        public ActionResult DoctorsList()
        {
            //List<Doctor> doctorsLis = new List<Doctor>();
            //try
            //{
            //    doctorsLis = bl.getAllDoctors().ToList();
            //}
            //catch (Exception ex)
            //{
            //    ViewBag.Message = String.Format(ex.Message);
            //    return View("LoginAdministratorBtn");
            //}
            //return View("DoctorsLis(doctorsLis)");

            List<DoctorModelClass> lists = modelDoctor.GetDoctors();

            return View("DoctorsList", lists);
        }
        [HttpPost]
        public ActionResult SignInDoctorBtn(string Name, string specialization, string WorkPlace, long ID, long Phone, string MailAddress, DateTime ExpirationDate, int LicenseId)
        {
            DoctorLicense license = new DoctorLicense();
            license.ExpirationDate = ExpirationDate;
            license.LicenseID = LicenseId;
            Doctor newDoctor = new Doctor();
            newDoctor.Name = Name;
            newDoctor.Specialization = specialization;
            newDoctor.WorkPlace = WorkPlace;
            newDoctor.ID = ID;
            newDoctor.Phone = Phone;
            newDoctor.MailAddress = MailAddress;
            newDoctor.License = license;
            try
            {
                bl.AddDoctor(newDoctor);
            }
            catch (Exception ex)
            {
                ViewBag.Message = String.Format(ex.Message);
                return View("SignInDoctor");
            }
            return View();
        }

        public ActionResult SaveNewDoctor(DoctorModelClass doc, string filename)
        {
            //Default Image For Doctor
            if (filename == string.Empty)
            {
                filename = "/img/DefaultImageForDoctor.jpg";
                //לשלוח לדרייב
            }
            doc.PicturePath = filename;
            modelDoctor.addDoctors(doc);
            List<DoctorModelClass> lists = modelDoctor.GetDoctors();
            return View("DoctorsList", lists);
        }
        

        public ActionResult AddDoctor()
        {
            return View();
        }
        public ActionResult EditDoctor(int id)
        {

            DoctorModelClass editdoc = modelDoctor.GetDoctor(id);
            return View(editdoc);
        }
        public ActionResult DeleteDoctor(int id)
        {
            DoctorModelClass doc = modelDoctor.GetDoctor(id);
            try
            {
                //   bl.deleteDoctor(doc);
            }
            catch (Exception ex)
            {
                ViewBag.Message = String.Format(ex.Message);
            }


            List<DoctorModelClass> lists = modelDoctor.GetDoctors();


            return View("DoctorsList", lists);
        }
        public ActionResult DetailsDoctor(int id)
        {
            DoctorModelClass d = modelDoctor.GetDoctor(id);

            return View(d);
        }
        public ActionResult SaveDoctor(Doctor d,string filename)
        {
            if (filename != string.Empty)
            {
                //לשלוח לדרייב
            }
            try
            {
                bl.UpdateDoctor(d);
            }
            catch (Exception ex)
            {
                ViewBag.Message = String.Format(ex.Message);
                return View("EditDoctor");
            }


            List<DoctorModelClass> lists = modelDoctor.GetDoctors();


            return View("DoctorsList", lists);
        }

    }
}
