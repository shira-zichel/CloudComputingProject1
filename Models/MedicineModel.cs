//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using BE;

//namespace CloudComputingProject1.Models
//{
//    public class MedicineModel
//    {
//        public  List<DrugModel> Medicines { get; set; }
//        public MedicineModel()
//        {
//            this.Medicines = new List<DrugModel>
//            {
//                new DrugModel
//                {
//                    ID=1,
//                    Name="Acamol",
//                    GenericName="cure1",
//                    //ImageUrl=@"~/vegefoods/images/acamol.PNG",
//                    DoseCharacteristics="2 cc",
//                    Producer="isrealCures",
//                    ActiveIngredients="bla bla",
//                    picturePath=@"/img/b1.jpg"

//                },
//                new DrugModel
//                {
//                    ID=7,
//                    Name="Nurofen",
//                    GenericName="cure1",
//                    //ImageUrl=@"~/vegefoods/images/acamol.PNG",
//                    DoseCharacteristics="2 cc",
//                    Producer="isrealCures",
//                    ActiveIngredients="bla bla",
//                    picturePath=@"/img/b2.jpg"
//                },
//                new DrugModel
//                {
//                    ID=6,
//                    Name="Advil",
//                    GenericName="cure1",
//                    //ImageUrl=@"~/vegefoods/images/acamol.PNG",
//                    DoseCharacteristics="2 cc",
//                    Producer="isrealCures",
//                    ActiveIngredients="bla bla",
//                    picturePath=@"/img/b1.jpg"
//                },
//                 new DrugModel
//                {
//                    ID=5,
//                    Name="Advil",
//                    GenericName="cure1",
//                    //ImageUrl=@"~/vegefoods/images/acamol.PNG",
//                    DoseCharacteristics="2 cc",
//                    Producer="isrealCures",
//                    ActiveIngredients="bla bla",
//                    picturePath=@"/img/b2.jpg"
//                },
//                new DrugModel
//                {
//                    ID=4,
//                    Name="Acamol",
//                    GenericName="cure1",
//                    //ImageUrl=@"~/vegefoods/images/acamol.PNG",
//                    DoseCharacteristics="2 cc",
//                    Producer="isrealCures",
//                    ActiveIngredients="bla bla",
//                    picturePath=@"/img/b1.jpg"
//                },
//                new DrugModel
//                {
//                    ID=3,
//                    Name="Acamol",
//                    GenericName="cure1",
//                    //ImageUrl=@"~/vegefoods/images/acamol.PNG",
//                    DoseCharacteristics="2 cc",
//                    Producer="isrealCures",
//                    ActiveIngredients="bla bla",
//                    picturePath=@"/img/b3.jpg"
//                },
//                 new DrugModel
//                {
//                    ID=2,
//                    Name="Acamol",
//                    GenericName="cure1",
//                    //ImageUrl=@"~/vegefoods/images/acamol.PNG",
//                    DoseCharacteristics="2 cc",
//                    Producer="isrealCures",
//                    ActiveIngredients="bla bla",
//                    picturePath=@"/img/b3.jpg"
//                }
//            };
//        }
//        public  List<DrugModel> GetMedicines()
//        {
//            return this.Medicines;

//        }
//        public DrugModel GetMedicine(int id)
//        {
//            //var result = (from f in Medicines
//            //              where f.ID == id
//            //              select f).Single<Medicine>();
//            return this.Medicines.Where(w => w.ID == id).FirstOrDefault();//.Select(s=>new Medicine() { ID=s.ID, ActiveIngredients=s.ActiveIngredients,Name=s.Name, DoseCharacteristics=s.DoseCharacteristics, GenericName=s.GenericName, Producer=s.Producer}).FirstOrDefault();
//        }
//        public void addMedicine(DrugModel m)
//        {
//            this.Medicines.Add(m);
//        }

//    }

//}
