using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CloudComputingProject1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home2
        public ActionResult Index()
        {
            return View();
        }

        // GET: Home2/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Home2/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home2/Create
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

        // GET: Home2/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Home2/Edit/5
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

        // GET: Home2/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Home2/Delete/5
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
        public ActionResult About()
        {
            return View();
        }
        public ActionResult BlogHome()
        {
            return View();
        }
        public ActionResult BlogSingle()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Departments()
        {
            return View();
        }
        public ActionResult DoctorsList()
        {
            return View(/*bl.getAllDoctors*/);
        }
        public ActionResult Doctors()
        {
            return View();
        }
        public ActionResult DrugsList()
        {
            return View(/*bl.getAllDrugs*/);
        }
        public ActionResult Elements()
        {
            return View();
        }
        public ActionResult Features()
        {
            return View();
        }
        public ActionResult SignInDoctor()
        {
            return View();
        }
        public ActionResult LoginManager()
        {
            return View();
        }
        public ActionResult SignInPatient()
        {
            return View();
        }
        public ActionResult PatientList()
        {
            return View(/*bl.getAllPatients*/);
        }
        public ActionResult Action()
        {
            return View();
        }
        public void SubmitManager()//מנהל
        {
            //בדיקה שהסיסמא נכונה ולהוביל אותו לעמוד המתאים  
        }
        public ActionResult LogInDoctor()
        {
            return View();
        }
        public ActionResult LogInPatient()
        {
            return View();
        }

        public void LogInDoctorBtn()
        {
            //bl.DoctorExist
            //להוביל לעמוד המתאים
        }
        public void LogInPatientBtn()
        {
            /*if (bl.DoctorExist)
            {
                //להובל אותו לעמוד שמציג את רשימת המרשמים
                //bl.PatientPrescription
            }
            else
            {
            //להדפיס שגיאה מתאימה
            }*/

        }
        [HttpPost]
        public void SignInDoctorBtn(string Name, string specialization, string WorkPlace, long ID, long Phone, string MailAddress)
        {
            try
            {
                //bl.addDoctor
            }
            catch
            {
                //להדפיס את החרידה שנשלחת מהפונקציה
            }

        }
        public void SignInPatientBtn()
        {
            try
            {
                //bl.addPatient
            }
            catch
            {
                //להדפיס את החריגה שנשלחת מהפונקציה
            }
            //להובל אותו לעמוד שמציג את רשימת המרשמים
            //bl.PatientPrescription
        }
    }
}
