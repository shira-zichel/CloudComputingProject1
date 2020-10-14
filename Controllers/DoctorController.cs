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
    public class DoctorController : Controller
    {

        //DoctorModel modelDoctor = new DoctorModel();


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
        //public ActionResult PrescriptionsById(int Id)
        //{
        //    //פונקציה שמחזירה את הרשימה של המרשמים של הפציינט לפי הת.ז
        //    //List<Prescription> PrescriptionList= bl.PatientPrescriptions(Id);
        //    PrescriptionAndListOfPrescriptions p = new PrescriptionAndListOfPrescriptions();
        //    return View("AddPrescription","Prescription", p);
        //}
        public ActionResult LogInDoctorBtn(int Id)
        {
            BL.ImplementBL bl = new BL.ImplementBL();
            try
            {
                bl.IsExistDoctor(Id.ToString());

            }
            catch (Exception ex)
            {
                ViewBag.Message = String.Format(ex.Message);
                return View("LogInDoctor");

            }
            return View("DoctorEnterPatientsId");
        }
        //public ActionResult AddPrescription()
        //{
        //    return View();
        //}

        //public ActionResult CreatePrescription(Prescription p)
        //{
        //    try
        //    {
        //        //bl.AddPrescription(p);
        //    }
        //    catch (Exception ex)
        //    {
        //        ViewBag.Message = String.Format(ex.Message);
        //        return View("AddPrescription");

        //    }
        //    ViewBag.Message = String.Format("The prescription was created successfully");

        //    return View("AddPrescription", new PrescriptionAndListOfPrescriptions());
        //}

        public ActionResult DoctorsList()
        {
            BL.ImplementBL bl = new BL.ImplementBL();
            List<Doctor> doctorsLis = new List<Doctor>();
            List<DoctorModelClass> lists = new List<DoctorModelClass>();
            try
            {
                doctorsLis = bl.getAllDoctors().ToList();
            }
            catch (Exception ex)
            {
                ViewBag.Message = String.Format(ex.Message);
                return View("LoginAdministratorBtn", "Home");
            }

            foreach (var item in doctorsLis)
            {
                DoctorModelClass d = new DoctorModelClass();
                d.ID = item.ID;
                d.MailAddress = item.MailAddress;
                d.Name = item.Name;
                d.Specialization = item.Specialization;
                d.ExpirationDate = item.ExpirationDate;
                d.PicturePath = "/img/t1.jpg";
                lists.Add(d);
            }
            return View("DoctorsList", lists);
        }
        //[HttpPost]
        //public ActionResult SignInDoctorBtn(string Name, string specialization, string WorkPlace, long ID, long Phone, string MailAddress, DateTime ExpirationDate, int LicenseId)
        //{
        //    Doctor newDoctor = new Doctor();
        //    newDoctor.Name = Name;
        //    newDoctor.Specialization = specialization;
        //    newDoctor.WorkPlace = WorkPlace;
        //    newDoctor.ID = ID;
        //    newDoctor.Phone = Phone;
        //    newDoctor.MailAddress = MailAddress;

        //    newDoctor.ExpirationDate = new DoctorLicense();
        //    try
        //    {
        //        bl.AddDoctor(newDoctor);
        //    }
        //    catch (Exception ex)
        //    {
        //        ViewBag.Message = String.Format(ex.Message);
        //        return View("SignInDoctor");
        //    }
        //    return View();
        //}

        public ActionResult SaveNewDoctor(Doctor doctorBE, string filename)
        {
            BL.ImplementBL bl = new BL.ImplementBL();
            //Default Image For Doctor
            if (filename == string.Empty)
            {
                filename = "/img/DefaultImageForDoctor.jpg";
                //לשלוח לדרייב
            }
            //doc.PicturePath = filename;
            //Doctor doctorBE = new Doctor();
            //doctorBE.ID = doc.ID;
            //doctorBE.Name = doc.Name;
            //doctorBE.Specialization = doc.Specialization;
            //doctorBE.MailAddress = doc.MailAddress;
            //doctorBE.ExpirationDate = doc.ExpirationDate;
            bl.AddDoctor(doctorBE);
            List<DoctorModelClass> lists = new List<DoctorModelClass>();
            foreach (var item in bl.getAllDoctors())
            {
                DoctorModelClass d = new DoctorModelClass();
                d.ID = item.ID;
                d.MailAddress = item.MailAddress;
                d.Name = item.Name;
                d.Specialization = item.Specialization;
                d.ExpirationDate = item.ExpirationDate;
                d.PicturePath = "/img/t1.jpg";
                lists.Add(d);
            }
            return View("DoctorsList", lists);
        }


        public ActionResult AddDoctor()
        {
            return View();
        }
        public ActionResult EditDoctor(int id)
        {
            BL.ImplementBL bl = new BL.ImplementBL();
            Doctor docBE = new Doctor();
            docBE = bl.getDoctor(id.ToString());
            DoctorModelClass editdoc = new DoctorModelClass();
            editdoc.ID = docBE.ID;
            editdoc.MailAddress = docBE.MailAddress;
            editdoc.Name = docBE.Name;
            editdoc.Specialization = docBE.Specialization;
            editdoc.ExpirationDate = docBE.ExpirationDate;
            editdoc.PicturePath = "/img/ DefaultImageForDoctor.jpg";
            return View(editdoc);
        }
        public ActionResult DeleteDoctor(int id)
        {
            BL.ImplementBL bl = new BL.ImplementBL();
            try
            {
                bl.deleteDoctor(id.ToString());
            }
            catch (Exception ex)
            {
                ViewBag.Message = String.Format(ex.Message);

            }
            List<Doctor> doctorsLis = new List<Doctor>();
            List<DoctorModelClass> lists = new List<DoctorModelClass>();
            try
            {
                doctorsLis = bl.getAllDoctors().ToList();
            }
            catch (Exception ex)
            {
                ViewBag.Message = String.Format(ex.Message);
                return View("LoginAdministratorBtn", "Home");
            }

            foreach (var item in doctorsLis)
            {
                DoctorModelClass d = new DoctorModelClass();
                d.ID = item.ID;
                d.MailAddress = item.MailAddress;
                d.Name = item.Name;
                d.Specialization = item.Specialization;
                d.ExpirationDate = item.ExpirationDate;
                d.PicturePath = "/img/t1.jpg";
                lists.Add(d);
            }
            return View("DoctorsList", lists);
        }
        public ActionResult DetailsDoctor(int id)
        {
            BL.ImplementBL bl = new BL.ImplementBL();
            Doctor docBE = bl.getDoctor(id.ToString());
            DoctorModelClass d = new DoctorModelClass();
            d.ID = docBE.ID;
            d.MailAddress = docBE.MailAddress;
            d.Name = docBE.Name;
            d.Specialization = docBE.Specialization;
            d.ExpirationDate = docBE.ExpirationDate;
            d.PicturePath = "/img/DefaultImageForDoctor.jpg";
            return View(d);
        }
        public ActionResult SaveDoctor(Doctor d, string filename)
        {
            BL.ImplementBL bl = new BL.ImplementBL();
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
                return View("EditDoctor", d);
            }
            List<Doctor> doctorsLis = new List<Doctor>();
            List<DoctorModelClass> lists = new List<DoctorModelClass>();
            try
            {
                doctorsLis = bl.getAllDoctors().ToList();
            }
            catch (Exception ex)
            {
                ViewBag.Message = String.Format(ex.Message);
                return View("Index", "Home");
            }

            foreach (var item in doctorsLis)
            {
                DoctorModelClass doc = new DoctorModelClass();
                doc.ID = item.ID;
                doc.MailAddress = item.MailAddress;
                doc.Name = item.Name;
                doc.Specialization = item.Specialization;
                doc.ExpirationDate = item.ExpirationDate;
                doc.PicturePath = "/img/t1.jpg";
                lists.Add(doc);
            }
            return View("DoctorsList", lists);
        }

    }
}
   