//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using BE;

//namespace CloudComputingProject1.Models
//{
//    public class PatientModel
//    {
//        public List<Patient> Patients { get; set; }
//        public PatientModel()
//        {
//            this.Patients = new List<Patient>
//            {
//                new Patient
//                {
//                     FirstName ="bla",
//                     LastName ="asas",
//                     ID =1,
//                     DateOfBirth=DateTime.Now,
//                     Prescriptions =new List<Prescription>()
//                     {
//                         new Prescription
//                         {

//                            ID =55,
//                              PatientName ="bla asas",
//                              PatientId=1,
//                               MedicineName="fgfhfgg",
//                                 MedicineId=3,
//                               amount=4,
//                             StartDate=DateTime.Now,
//                            EndDate=DateTime.Now,
//                              ReferringDoctor=new Doctor(){ID=5,Name="doc1" }
//                         }

//                     },
//                      Gender ="male"
//                },
//                 new Patient
//                {
//                     FirstName ="bla",
//                     LastName ="asas",
//                     ID =2,
//                     DateOfBirth=DateTime.Now,
//                     Prescriptions =new List<Prescription>()
//                     {
//                         new Prescription
//                         {

//                            ID =2,
//                              PatientName ="bla asas",
//                              PatientId=1,
//                               MedicineName="fgfhfgg",
//                                 MedicineId=3,
//                               amount=4,
//                             StartDate=DateTime.Now,
//                            EndDate=DateTime.Now,
//                              ReferringDoctor=new Doctor(){ID=5,Name="doc1" }
//                         },
//                          new Prescription
//                         {

//                            ID =3,
//                              PatientName ="bla asas",
//                              PatientId=1,
//                               MedicineName="fgfhfgg",
//                                 MedicineId=3,
//                               amount=4,
//                             StartDate=DateTime.Now,
//                            EndDate=DateTime.Now,
//                              ReferringDoctor=new Doctor(){ID=5,Name="doc1" }
//                         },
//                          new Prescription
//                         {

//                            ID =555,
//                              PatientName ="bla asas",
//                              PatientId=1,
//                               MedicineName="fgfhfgg",
//                                 MedicineId=3,
//                               amount=4,
//                             StartDate=DateTime.Now,
//                            EndDate=DateTime.Now,
//                              ReferringDoctor=new Doctor(){ID=5,Name="doc1" }
//                         },
//                          new Prescription
//                         {

//                            ID =99,
//                              PatientName ="bla asas",
//                              PatientId=1,
//                               MedicineName="fgfhfgg",
//                                 MedicineId=3,
//                               amount=4,
//                             StartDate=DateTime.Now,
//                            EndDate=DateTime.Now,
//                              ReferringDoctor=new Doctor(){ID=5,Name="doc1" }
//                         },
//                          new Prescription
//                         {

//                            ID =951,
//                              PatientName ="bla asas",
//                              PatientId=1,
//                               MedicineName="fgfhfgg",
//                                 MedicineId=3,
//                               amount=4,
//                             StartDate=DateTime.Now,
//                            EndDate=DateTime.Now,
//                              ReferringDoctor=new Doctor(){ID=5,Name="doc1" }
//                         },
//                          new Prescription
//                         {

//                            ID =023,
//                              PatientName ="bla asas",
//                              PatientId=1,
//                               MedicineName="fgfhfgg",
//                                 MedicineId=3,
//                               amount=4,
//                             StartDate=DateTime.Now,
//                            EndDate=DateTime.Now,
//                              ReferringDoctor=new Doctor(){ID=5,Name="doc1" }
//                         }
//                          ,
//                          new Prescription
//                         {

//                            ID =36,
//                              PatientName ="bla asas",
//                              PatientId=1,
//                               MedicineName="fgfhfgg",
//                                 MedicineId=3,
//                               amount=4,
//                             StartDate=DateTime.Now,
//                            EndDate=DateTime.Now,
//                              ReferringDoctor=new Doctor(){ID=5,Name="doc1" }
//                         },
//                          new Prescription
//                         {

//                            ID =98,
//                              PatientName ="bla asas",
//                              PatientId=1,
//                               MedicineName="fgfhfgg",
//                                 MedicineId=3,
//                               amount=4,
//                             StartDate=DateTime.Now,
//                            EndDate=DateTime.Now,
//                              ReferringDoctor=new Doctor(){ID=5,Name="doc1" }
//                         }
//                          ,
//                          new Prescription
//                         {

//                            ID =963,
//                              PatientName ="bla asas",
//                              PatientId=1,
//                               MedicineName="fgfhfgg",
//                                 MedicineId=3,
//                               amount=4,
//                             StartDate=DateTime.Now,
//                            EndDate=DateTime.Now,
//                              ReferringDoctor=new Doctor(){ID=5,Name="doc1" }
//                         }
//                     },
//                      Gender ="male"
//                }, new Patient
//                {
//                     FirstName ="bla",
//                     LastName ="asas",
//                     ID =4,
//                     DateOfBirth=DateTime.Now,
//                     Prescriptions =new List<Prescription>()
//                     {
//                         new Prescription
//                         {

//                            ID =2,
//                              PatientName ="bla asas",
//                              PatientId=1,
//                               MedicineName="fgfhfgg",
//                                 MedicineId=3,
//                               amount=4,
//                             StartDate=DateTime.Now,
//                            EndDate=DateTime.Now,
//                              ReferringDoctor=new Doctor(){ID=5,Name="doc1" }
//                         },
//                          new Prescription
//                         {

//                            ID =3,
//                              PatientName ="bla asas",
//                              PatientId=1,
//                               MedicineName="fgfhfgg",
//                                 MedicineId=3,
//                               amount=4,
//                             StartDate=DateTime.Now,
//                            EndDate=DateTime.Now,
//                              ReferringDoctor=new Doctor(){ID=5,Name="doc1" }
//                         }


//                     },
//                      Gender ="male"
//                }, new Patient
//                {
//                     FirstName ="bla",
//                     LastName ="asas",
//                     ID =3,
//                     DateOfBirth=DateTime.Now,
//                     Prescriptions =new List<Prescription>()
//                     {
//                         new Prescription
//                         {

//                            ID =2,
//                              PatientName ="bla asas",
//                              PatientId=1,
//                               MedicineName="fgfhfgg",
//                                 MedicineId=3,
//                               amount=4,
//                             StartDate=DateTime.Now,
//                            EndDate=DateTime.Now,
//                              ReferringDoctor=new Doctor(){ID=5,Name="doc1" }
//                         },
//                          new Prescription
//                         {

//                            ID =3,
//                              PatientName ="bla asas",
//                              PatientId=1,
//                               MedicineName="fgfhfgg",
//                                 MedicineId=3,
//                               amount=4,
//                             StartDate=DateTime.Now,
//                            EndDate=DateTime.Now,
//                              ReferringDoctor=new Doctor(){ID=5,Name="doc1" }
//                         }


//                     },
//                      Gender ="male"
//                }
//             };
//        }
//        public List<Patient> GetAllPatients()
//        {
//            return this.Patients;
//        }
//        public Patient GetPatient(int id)
//        {
//            var result = (from f in Patients
//                          where f.ID == id
//                          select f).Single<Patient>();
//            return result;
//        }
//        public void addPatient(Patient p)
//        {
//            this.Patients.Add(p);
//        }
//    }

//}
