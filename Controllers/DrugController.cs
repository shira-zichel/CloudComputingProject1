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

    public class DrugController : Controller
    {
        public ActionResult SaveNewDrug(Medicine drug, string filename)
        {
            BL.ImplementBL bl = new BL.ImplementBL();
            /*filename ;
              לשלוח לדרייב
             */
            bl.AddMedicine(drug);
            List<DrugModel> lists = new List<DrugModel>();
            List<Medicine> medicinesList = bl.getAllMedicines().ToList();
            try
            {
                foreach (var item in medicinesList)
                {
                    lists.Add(new DrugModel { Name = item.Name, Producer = item.Producer, GenericName = item.GenericName, ActiveIngredients = item.ActiveIngredients, picturePath = "/img/b1.jpg", MedecienId = item.MedecienId, Ndc = item.Ndc, Properties = item.Properties });
                }

            }
            catch (Exception ex)
            {
                ViewBag.Message = String.Format(ex.Message);
                return View("AddDrug", "Drug");
            }
            return View("DrugsList", lists);
        }
        public ActionResult AddDrug()
        {
            return View();
        }
        public ActionResult DrugsList()
        {
            BL.ImplementBL bl = new BL.ImplementBL();
            List<DrugModel> lists = new List<DrugModel>();
            List<Medicine> medicinesList = bl.getAllMedicines().ToList();
            try
            {
                foreach (var item in medicinesList)
                {
                    lists.Add(new DrugModel { Name = item.Name, Producer = item.Producer, GenericName = item.GenericName, ActiveIngredients = item.ActiveIngredients, picturePath = "/img/b1.jpg", MedecienId = item.MedecienId, Ndc = item.Ndc, Properties = item.Properties });
                }

            }
            catch (Exception ex)
            {
                ViewBag.Message = String.Format(ex.Message);
                return View("LoginAdministratorBtn", "Home");
            }
            return View("DrugsList", lists);
        }
        public ActionResult EditDrug(string id)
        {
            BL.ImplementBL bl = new BL.ImplementBL();
            Medicine medBE = new Medicine();
            medBE = bl.GetMedicine(id);
            DrugModel editmed = new DrugModel();
            editmed.Name = medBE.Name;
            editmed.Producer = medBE.Producer;
            editmed.GenericName = medBE.GenericName;
            editmed.ActiveIngredients = medBE.ActiveIngredients;
            editmed.MedecienId = medBE.MedecienId;
            editmed.Ndc = medBE.Ndc;
            editmed.Properties = medBE.Properties;
            editmed.picturePath = "/img/b2.jpg";
            return View(editmed);
        }
        public ActionResult DeleteDrug(string id)
        {
            BL.ImplementBL bl = new BL.ImplementBL();
            try
            {
                bl.deleteMediciner(id);
            }
            catch (Exception ex)
            {
                ViewBag.Message = String.Format(ex.Message);
            }
            List<DrugModel> lists = new List<DrugModel>();
            List<Medicine> medicinesList = bl.getAllMedicines().ToList();
            try
            {
                foreach (var item in medicinesList)
                {
                    lists.Add(new DrugModel { Name = item.Name, Producer = item.Producer, GenericName = item.GenericName, ActiveIngredients = item.ActiveIngredients, picturePath = "/img/b1.jpg", MedecienId = item.MedecienId, Ndc = item.Ndc, Properties = item.Properties });
                }

            }
            catch (Exception ex)
            {
                ViewBag.Message = String.Format(ex.Message);
                return View("LoginAdministratorBtn", "Home");
            }
            return View("DrugsList", lists);
        }
        public ActionResult DetailsDrug(string id)
        {

            BL.ImplementBL bl = new BL.ImplementBL();
            Medicine docBE = bl.GetMedicine(id);
            DrugModel d = new DrugModel { Name = docBE.Name, Producer = docBE.Producer, GenericName = docBE.GenericName, ActiveIngredients = docBE.ActiveIngredients, picturePath = "/img/b1.jpg", MedecienId = docBE.MedecienId, Ndc = docBE.Ndc, Properties = docBE.Properties };
            return View(d);
        }
        public ActionResult SaveDrug(Medicine m, string filename)
        {
            BL.ImplementBL bl = new BL.ImplementBL();
            if (filename != string.Empty)
            {
                //לשלוח לדרייב
            }
            try
            {
                bl.UpdateMedicine(m);
            }
            catch (Exception ex)
            {
                ViewBag.Message = String.Format(ex.Message);
                return View("EditDrug", m);
            }
            List<Medicine> medList = bl.getAllMedicines().ToList();
            List<DrugModel> lists = new List<DrugModel>();
            foreach (var item in medList)
            {
                lists.Add(new DrugModel { Name = item.Name, Producer = item.Producer, GenericName = item.GenericName, ActiveIngredients = item.ActiveIngredients, picturePath = "/img/b1.jpg", MedecienId = item.MedecienId, Ndc = item.Ndc, Properties = item.Properties });
            }
            return View("DrugsList", lists);
        }
    }
}
