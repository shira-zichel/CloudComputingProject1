using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BE;
using CloudComputingProject1.Models;

namespace CloudComputingProject1.Controllers
{
   
    public class HomeController : Controller
    {
       public BL.ImplementBL bl = new BL.ImplementBL();
        //MedicineModel model = new MedicineModel();
        //DoctorModel modelDoctor = new DoctorModel();
        //PatientModel modelPatient = new PatientModel();
        //DrugModel modelDrug = new DrugModel();
        // GET: Home2
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult SignInDoctor()
        {
            return View("SignInDoctor", "Doctor");
        }
        public ActionResult LoginAdministrator()
        {
            return View();
        }
        public ActionResult SignInPatient()
        {
            return View();
        }
     
        public ActionResult Action()
        {
            return View();
        }
       
      

       

        public ActionResult LoginAdministratorBtn(string Password)
        {
            try
            {
                //bl.isAdministrator(Password);
            }
            catch (Exception ex)
            {
                ViewBag.Message = String.Format(ex.Message);
                return View("LoginAdministrator");

            }
            return View();
        }






        #region Doctor
        //public ActionResult LogInDoctor()
        //{
        //    return View();
        //}
        //public ActionResult PrescriptionsById(int Id)
        //{
        //    //פונקציה שמחזירה את הרשימה של המרשמים של הפציינט לפי הת.ז
        //  //List<Prescription> PrescriptionList= bl.PatientPrescriptions(Id);
        //   PrescriptionAndListOfPrescriptions p = new PrescriptionAndListOfPrescriptions();
        //   return View("AddPrescription",p);
        //}
        //public ActionResult LogInDoctorBtn(int Id)
        //{
        //    try
        //    {
        //       // bl.ExistDoctor(Id);

        //    }
        //    catch (Exception ex)
        //    {
        //        ViewBag.Message = String.Format(ex.Message);
        //        return View("LogInDoctor");

        //    }
        //    return View("DoctorEnterPatientsId");
        //}
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

        //    return View("AddPrescription",new PrescriptionAndListOfPrescriptions());
        //}


        //public ActionResult DoctorsList()
        //{
        //    //List<Doctor> doctorsLis = new List<Doctor>();
        //    //try
        //    //{
        //    //    doctorsLis = bl.getAllDoctors().ToList();
        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    ViewBag.Message = String.Format(ex.Message);
        //    //    return View("LoginAdministratorBtn");
        //    //}
        //    //return View("DoctorsLis(doctorsLis)");

        //    List<DoctorModelClass> lists = modelDoctor.GetDoctors();
            
        //    return View("DoctorsList", lists);
        //}
        //[HttpPost]
        //public ActionResult SignInDoctorBtn(string Name, string specialization, string WorkPlace, long ID, long Phone, string MailAddress, DateTime ExpirationDate, int LicenseId)
        //{
        //    DoctorLicense license = new DoctorLicense();
        //    license.ExpirationDate = ExpirationDate;
        //    license.LicenseID = LicenseId;
        //    Doctor newDoctor = new Doctor();
        //    newDoctor.Name = Name;
        //    newDoctor.Specialization = specialization;
        //    newDoctor.WorkPlace = WorkPlace;
        //    newDoctor.ID = ID;
        //    newDoctor.Phone = Phone;
        //    newDoctor.MailAddress = MailAddress;
        //    newDoctor.License = license;
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

        //public ActionResult SaveNewDoctor(DoctorModelClass doc,string filename)
        //{
        //    //Default Image For Doctor
        //    if (filename==string.Empty)
        //    {
        //        filename = "/img/DefaultImageForDoctor.jpg";
        //    }
        //    doc.PicturePath = filename;
        //    modelDoctor.addDoctors(doc);
        //    List<DoctorModelClass> lists = modelDoctor.GetDoctors();
        //    return View("DoctorsList", lists);
        //}

        
        //public ActionResult AddDoctor()
        //{
        //    return View();
        //}
        //public ActionResult EditDoctor(int id)
        //{

        //    DoctorModelClass editdoc = modelDoctor.GetDoctor(id);
        //    return View(editdoc);
        //}
        //public ActionResult DeleteDoctor(int id)
        //{
        //    DoctorModelClass doc = modelDoctor.GetDoctor(id);
        //    try
        //    {
        //     //   bl.deleteDoctor(doc);
        //    }
        //    catch (Exception ex)
        //    {
        //        ViewBag.Message = String.Format(ex.Message);
        //    }


        //    List<DoctorModelClass> lists = modelDoctor.GetDoctors();

           
        //    return View("DoctorsList", lists);
        //}
        //public ActionResult DetailsDoctor(int id)
        //{
        //    DoctorModelClass d = modelDoctor.GetDoctor(id);
           
        //    return View(d);
        //}
        //public ActionResult SaveDoctor(Doctor d)
        //{
        //    try
        //    {
        //        bl.UpdateDoctor(d);
        //    }
        //    catch (Exception ex)
        //    {
        //        ViewBag.Message = String.Format(ex.Message);
        //        return View("EditDoctor");
        //    }


        //    List<DoctorModelClass> lists = modelDoctor.GetDoctors();

            
        //    return View("DoctorsList", lists);
        //}

        #endregion

        #region Medicine
       
        //public ActionResult SaveNewDrug(DrugModel drug , string filename)
        //{
        //    drug.picturePath = filename;
        //    model.addMedicine(drug);

        //    List<DrugModel> lists = model.GetMedicines();
        //    //foreach (DrugModel item in model.GetMedicines())
        //    //{
        //    //    lists.Add(new DrugModel { Name = item.Name, Producer = item.Producer, GenericName = item.GenericName, ActiveIngredients = item.ActiveIngredients, DoseCharacteristics = item.DoseCharacteristics, ID = item.ID, picturePath = (string)bl.getPictureById(item.ID) });
        //    //}

        //    return View("DrugsList", lists);
        //}
        //public ActionResult AddDrug()
        //{
        //    return View();
        //}
        //public ActionResult DrugsList()
        //{
        //List<DrugModel> lists = new List<DrugModel>();
        //    lists = model.GetMedicines();

        //    //try
        //    //{
        //    //    foreach (DrugModel item in model.GetMedicines())
        //    //    {
        //    //        lists.Add(new DrugModel { Name = item.Name, Producer = item.Producer, GenericName = item.GenericName, ActiveIngredients = item.ActiveIngredients, DoseCharacteristics = item.DoseCharacteristics, ID = item.ID, picturePath = (string)bl.getPictureById(item.ID) });
        //    //    }
                
        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    ViewBag.Message = String.Format(ex.Message);
        //    //    return View("LoginAdministratorBtn");
        //    //}
        //    return View("DrugsList", lists);
        //}
        //public ActionResult EditDrug(int id)
        //{

        //    string picturePath = (string)bl.getPictureById(id);
        //    DrugModel m = model.GetMedicine(id);

        //    DrugModel modelush = new DrugModel { Name = m.Name, Producer = m.Producer, GenericName = m.GenericName, ActiveIngredients = m.ActiveIngredients, DoseCharacteristics = m.DoseCharacteristics, ID = m.ID, picturePath = (string)bl.getPictureById(m.ID) };
        //    return View(modelush);
        //}
        //public ActionResult DeleteDrug(int id)
        //{
        //    try
        //    {
        //        bl.deleteMediciner(id);
        //    }
        //    catch (Exception ex)
        //    {
        //        ViewBag.Message = String.Format(ex.Message);
        //    }


        //    List<DrugModel> lists = new List<DrugModel>();
        //        foreach (DrugModel item in model.GetMedicines())
        //        {
        //            lists.Add(new DrugModel { Name = item.Name, Producer = item.Producer, GenericName = item.GenericName, ActiveIngredients = item.ActiveIngredients, DoseCharacteristics = item.DoseCharacteristics, ID = item.ID, picturePath = (string)bl.getPictureById(item.ID) });
        //        }
        //        return View("DrugsList", lists);
        //}

        //public ActionResult DetailsDrug(int id)
        //{

        //    string picturePath = (string)bl.getPictureById(id);
        //    DrugModel m = model.GetMedicine(id);

        //    DrugModel modelush = new DrugModel { Name = m.Name, Producer = m.Producer, GenericName = m.GenericName, ActiveIngredients = m.ActiveIngredients, DoseCharacteristics = m.DoseCharacteristics, ID = m.ID, picturePath = (string)bl.getPictureById(m.ID) }; 
        //    return View(modelush);
        //}
        //public ActionResult SaveDrug(DrugModel m)
        //{
        //    Medicine med = new Medicine() { Name = m.Name, ID = m.ID, Producer = m.Producer, GenericName = m.GenericName, ActiveIngredients = m.ActiveIngredients, DoseCharacteristics = m.DoseCharacteristics };
        //    string picturePath = m.picturePath;
        //    try
        //    {
        //     //   bl.UpdateMedicine(med, picturePath);
        //    }
        //    catch (Exception ex)
        //    {
        //        ViewBag.Message = String.Format(ex.Message);
        //        return View("EditDrug",m);
        //    }



        //    List<DrugModel> lists = new List<DrugModel>();
        //    foreach (DrugModel item in model.GetMedicines())
        //    {
        //        lists.Add(new DrugModel { Name = item.Name, Producer = item.Producer, GenericName = item.GenericName, ActiveIngredients = item.ActiveIngredients, DoseCharacteristics = item.DoseCharacteristics, ID = item.ID, picturePath = (string)bl.getPictureById(item.ID) });
        //    }
        //    return View("DrugsList", lists);
        //}
        #endregion

        #region Patient
       
       
        //public ActionResult LogInPatientBtn(int Id)
        //{
        //    PatientModel model = new PatientModel();
        //    List<Prescription> p = model.GetPatient(Id).Prescriptions;
        //    return View("PatientPrescriptionsList",p);
        //    //try
        //    //{
        //    //    bl.ExsistPtient(Id);
        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    ViewBag.Message = String.Format(ex.Message);
        //    //    return View("LogInPatient");

        //    //}
        //    //return View(bl.PatientPrescriptions(Id));
        //}
        //public ActionResult PatientsList()
        //{
        //    //List<Patient> patiensList = new List<Patient>();
        //    //try
        //    //{
        //    //    patiensList = bl.getAllPatients().ToList();
        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    ViewBag.Message = String.Format(ex.Message);
        //    //    return View("LoginAdministratorBtn");
        //    //}
        //    //return View(patiensList);
        //    List<Patient> patiensList = modelPatient.GetAllPatients();


        //    return View( patiensList);
        //}
        //public ActionResult SignInPatientBtn(string FirstName, string LastName, long ID, string Gender, DateTime DateOfBirth)
        //{
        //    Patient newPatient = new Patient();
        //    newPatient.FirstName = FirstName;
        //    newPatient.LastName = LastName;
        //    newPatient.ID = ID;
        //    newPatient.Gender = Gender;
        //    newPatient.DateOfBirth = DateOfBirth;
        //    newPatient.Prescriptions = new List<Prescription>();
        //    try
        //    {
        //        bl.AddPatient(newPatient);
        //    }
        //    catch (Exception ex)
        //    {
        //        ViewBag.Message = String.Format(ex.Message);
        //        return View("SignInPatient");
        //    }

        //    return View();

        //}
        //public ActionResult CreatePatient()
        //{
        //    return View();
        //}

        //public ActionResult AddNewPatient(Patient p)
        //{
        //    modelPatient.addPatient(p);
        //    List<Patient> patiensList = modelPatient.GetAllPatients();


        //    return View("PatientsList", patiensList);
        //}

        //public ActionResult SavePatient(Patient p)
        //{
        //    try
        //    {
        //        bl.UpdatePatient(p);
        //    }
        //    catch (Exception ex)
        //    {
        //        ViewBag.Message = String.Format(ex.Message);
        //        return View("EditPatient", p);
        //    }
          
        //    List<Patient> patiensList = modelPatient.GetAllPatients();
        //    return View("PatientsList", patiensList);
        //}
        //public ActionResult DeletePatient(int id)
        //{
        //    try
        //    {
        //        Patient p = modelPatient.GetPatient(id);
        //        bl.deletePatient(p);
              
        //    }
        //    catch (Exception ex)
        //    {
        //        ViewBag.Message = String.Format(ex.Message);             
        //    }
        //    List<Patient> patiensList = modelPatient.GetAllPatients();
        //    return View("PatientsList", patiensList);
        //}

        //public ActionResult EditPatient(int id)
        //{
        //    Patient p = modelPatient.GetPatient(id);          
        //    return View( p);
        //}

        //public ActionResult DetailsPatient(int id)
        //{

        //    Patient p = modelPatient.GetPatient(id);
        //    return View(p);
        //}
        #endregion

        #region Prescription
        //public ActionResult PrescriptionsList()
        //{

        //    PrescriptionModel model = new PrescriptionModel();
        //    List<Prescription> lists = model.GetAllPrescriptions();

        //    //List <Prescription> PrescriptionsList = new List<Prescription>();
        //    //try
        //    //{
        //    //    PrescriptionsList = bl.getAllPrescriptions().ToList();
        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    ViewBag.Message = String.Format(ex.Message);
        //    //    return View("LoginAdministratorBtn");
        //    //}
        //    return View("PrescriptionsList", lists);
        //}
        #endregion

        #region GraphDrug
        public ActionResult GraphDrug()
        {
            
            return View(bl.getAllMedicines());
        }
        #endregion
    }
}
