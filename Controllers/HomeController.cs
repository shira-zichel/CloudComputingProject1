using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BE;


namespace CloudComputingProject1.Controllers
{
    public class HomeController : Controller
    {
       BL.ImplementBL bl = new BL.ImplementBL();
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
            List<Doctor> doctorsLis = new List<Doctor>();
            try
            {
              doctorsLis=bl.getAllDoctors().ToList();
            }
            catch(Exception ex)
            {
                //לתפוס את החריגה ולהדפםיס שגיאה
            }
            return View(doctorsLis);
        }
        public ActionResult Doctors()
        {
            return View();
        }
        public ActionResult DrugsList()
        {
            List<Medicine> drugsList = new List<Medicine>();
            try
            {
                drugsList = bl.getAllMedicines().ToList();
            }
            catch (Exception ex)
            {
                //לתפוס את החריגה ולהדפםיס שגיאה
            }
            return View(drugsList);
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
        public ActionResult LoginAdministrator()
        {
            return View();
        }
        public ActionResult SignInPatient()
        {
            return View();
        }
        public ActionResult PatientList()
        {
            List<Patient> patiensList = new List<Patient>();
            try
            {
                patiensList = bl.getAllPatients().ToList();
            }
            catch (Exception ex)
            {
                //לתפוס את החריגה ולהדפםיס שגיאה
            }
            return View(patiensList);
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
        public void SignInDoctorBtn(string Name, string specialization, string WorkPlace, long ID, long Phone, string MailAddress, DateTime ExpirationDate, int LicenseId)
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
            catch(Exception ex)
            {
                //להדפיס את החרידה שנשלחת מהפונקציה
            }
            //return view();
        }
        public void SignInPatientBtn(string FirstName, string LastName, long ID,  string Gender,DateTime DateOfBirth)
        {
            Patient newPatient = new Patient();
            newPatient.FirstName = FirstName;
            newPatient.LastName = LastName;
            newPatient.ID = ID;
            newPatient.Gender = Gender;
            newPatient.DateOfBirth = DateOfBirth;
            newPatient.Prescriptions = new List<Prescription>();
            try
            {
                bl.AddPatient(newPatient);
            }
            catch(Exception ex)
            {
                //להדפיס את החריגה שנשלחת מהפונקציה
            }

           
        }
    }
}
