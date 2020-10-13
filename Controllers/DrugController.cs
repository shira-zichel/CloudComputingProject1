using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BE;
using CloudComputingProject1.Models;

namespace CloudComputingProject1.Controllers
{
    public class DrugController : Controller
    {
        MedicineModel model = new MedicineModel();
        DrugModel modelDrug = new DrugModel();
        public BL.ImplementBL bl = new BL.ImplementBL();

        //// GET: Drug
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //// GET: Drug/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: Drug/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Drug/Create
        //[HttpPost]
        //public ActionResult Create(FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Drug/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Drug/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Drug/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Drug/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
        public ActionResult SaveNewDrug(DrugModel drug, string filename)
        {
            drug.picturePath = filename;
            model.addMedicine(drug);

            List<DrugModel> lists = model.GetMedicines();
            //foreach (DrugModel item in model.GetMedicines())
            //{
            //    lists.Add(new DrugModel { Name = item.Name, Producer = item.Producer, GenericName = item.GenericName, ActiveIngredients = item.ActiveIngredients, DoseCharacteristics = item.DoseCharacteristics, ID = item.ID, picturePath = (string)bl.getPictureById(item.ID) });
            //}

            return View("DrugsList", lists);
        }
        public ActionResult AddDrug()
        {
            return View();
        }
        public ActionResult DrugsList()
        {
            List<DrugModel> lists = new List<DrugModel>();
            lists = model.GetMedicines();

            //try
            //{
            //    foreach (DrugModel item in model.GetMedicines())
            //    {
            //        lists.Add(new DrugModel { Name = item.Name, Producer = item.Producer, GenericName = item.GenericName, ActiveIngredients = item.ActiveIngredients, DoseCharacteristics = item.DoseCharacteristics, ID = item.ID, picturePath = (string)bl.getPictureById(item.ID) });
            //    }

            //}
            //catch (Exception ex)
            //{
            //    ViewBag.Message = String.Format(ex.Message);
            //    return View("LoginAdministratorBtn");
            //}
            return View("DrugsList", lists);
        }
        public ActionResult EditDrug(int id)
        {

            string picturePath = (string)bl.getPictureById(id);
            DrugModel m = model.GetMedicine(id);

            DrugModel modelush = new DrugModel { Name = m.Name, Producer = m.Producer, GenericName = m.GenericName, ActiveIngredients = m.ActiveIngredients, DoseCharacteristics = m.DoseCharacteristics, ID = m.ID, picturePath = (string)bl.getPictureById(m.ID) };
            return View(modelush);
        }
        public ActionResult DeleteDrug(int id)
        {
            try
            {
                bl.deleteMediciner(id);
            }
            catch (Exception ex)
            {
                ViewBag.Message = String.Format(ex.Message);
            }


            List<DrugModel> lists = new List<DrugModel>();
            foreach (DrugModel item in model.GetMedicines())
            {
                lists.Add(new DrugModel { Name = item.Name, Producer = item.Producer, GenericName = item.GenericName, ActiveIngredients = item.ActiveIngredients, DoseCharacteristics = item.DoseCharacteristics, ID = item.ID, picturePath = (string)bl.getPictureById(item.ID) });
            }
            return View("DrugsList", lists);
        }

        public ActionResult DetailsDrug(int id)
        {

            string picturePath = (string)bl.getPictureById(id);
            DrugModel m = model.GetMedicine(id);

            DrugModel modelush = new DrugModel { Name = m.Name, Producer = m.Producer, GenericName = m.GenericName, ActiveIngredients = m.ActiveIngredients, DoseCharacteristics = m.DoseCharacteristics, ID = m.ID, picturePath = (string)bl.getPictureById(m.ID) };
            return View(modelush);
        }
        public ActionResult SaveDrug(DrugModel m,string filename)
        {
            if(filename!=string.Empty)
            {
                //לשלוח לשירן
            }
            Medicine med = new Medicine() { Name = m.Name, ID = m.ID, Producer = m.Producer, GenericName = m.GenericName, ActiveIngredients = m.ActiveIngredients, DoseCharacteristics = m.DoseCharacteristics };
            string picturePath = m.picturePath;
            try
            {
                //   bl.UpdateMedicine(med, picturePath);
            }
            catch (Exception ex)
            {
                ViewBag.Message = String.Format(ex.Message);
                return View("EditDrug", m);
            }



            List<DrugModel> lists = new List<DrugModel>();
            foreach (DrugModel item in model.GetMedicines())
            {
                lists.Add(new DrugModel { Name = item.Name, Producer = item.Producer, GenericName = item.GenericName, ActiveIngredients = item.ActiveIngredients, DoseCharacteristics = item.DoseCharacteristics, ID = item.ID, picturePath = (string)bl.getPictureById(item.ID) });
            }
            return View("DrugsList", lists);
        }
    }
}
