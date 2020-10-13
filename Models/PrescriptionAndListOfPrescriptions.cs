using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BE;

namespace CloudComputingProject1.Models
{
    public class PrescriptionAndListOfPrescriptions
    {
        public Prescription prescription { set; get; }
        public List<Prescription> prescriptionsList { set; get; }
        public PrescriptionAndListOfPrescriptions()
        {
            this.prescriptionsList = new List<Prescription>
            {
                new Prescription
                {

                    ID = 55,
                    PatientName = "ytr",
                    PatientId = 1,
                    MedicineName = "Acamol",
                    MedicineId = 3,
                    amount = 4,
                    StartDate = new DateTime(1999, 05, 12),
                    EndDate = new DateTime(1999, 08, 12),
                    ReferringDoctor = new Doctor() { ID = 5, Name = "doc1" }
                },
                new Prescription
                {

                    ID = 56,
                    PatientName = "tt",
                    PatientId = 1,
                    MedicineName = "Advil",
                    MedicineId = 3,
                    amount = 4,
                    StartDate = new DateTime(1999, 06, 12),
                    EndDate = new DateTime(1999, 06, 28),
                    ReferringDoctor = new Doctor() { ID = 5, Name = "doc1" }
                },
                new Prescription
                {

                    ID = 56,
                    PatientName = "hh",
                    PatientId = 1,
                    MedicineName = "Advil",
                    MedicineId = 3,
                    amount = 4,
                    StartDate = new DateTime(1999, 09, 1),
                    EndDate =new DateTime(1999, 12, 1),
                    ReferringDoctor = new Doctor() { ID = 5, Name = "doc1" }
                },
                new Prescription
                {

                    ID = 56,
                    PatientName = "il",
                    PatientId = 1,
                    MedicineName = "Advil",
                    MedicineId = 3,
                    amount = 4,
                    StartDate = new DateTime(1999, 10, 1),
                    EndDate = new DateTime(1999, 10, 15),
                    ReferringDoctor = new Doctor() { ID = 5, Name = "doc1" }
                },
                new Prescription
                {

                    ID = 56,
                    PatientName = "Ad",
                    PatientId = 1,
                    MedicineName = "Advil",
                    MedicineId = 3,
                    amount = 4,
                    StartDate = new DateTime(1989, 06, 12),
                    EndDate = new DateTime(1989, 06, 18),
                    ReferringDoctor = new Doctor() { ID = 5, Name = "doc1" }
                },
                new Prescription
                {

                    ID = 565,
                    PatientName = "Ad",
                    PatientId = 1,
                    MedicineName = "Advil",
                    MedicineId = 3,
                    amount = 4,
                    StartDate = new DateTime(1989, 06, 12),
                    EndDate = new DateTime(1989, 06, 18),
                    ReferringDoctor = new Doctor() { ID = 5, Name = "doc1" }
                },
                new Prescription
                {

                    ID = 5856,
                    PatientName = "Ad",
                    PatientId = 1,
                    MedicineName = "Advil",
                    MedicineId = 3,
                    amount = 4,
                    StartDate = new DateTime(1989, 06, 12),
                    EndDate = new DateTime(1989, 06, 18),
                    ReferringDoctor = new Doctor() { ID = 5, Name = "doc1" }
                },
            };
       
        }
        public List<Prescription> GetAllPrescriptions()
        {
            return this.prescriptionsList;
        }
    }

}
