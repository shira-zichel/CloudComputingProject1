using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using BE;

namespace DAL
{
    public class ImplementDAL
    {
        PharmacyContext db = new PharmacyContext();
        ///////////////Administrator//////////////
        public void  UpdateAdministrator(Administrator administrator) 
        {
            var admin = (from item in db.Administrators.ToList()
                         where (item.ID == administrator.ID)
                         select item).FirstOrDefault();
            if (admin == null)
            {
                throw new Exception("administrator dosn't exsist");
            }
            else
            {
                db.Administrators.Remove(admin);
                db.Administrators.Add(administrator);
                db.SaveChanges();
            }
            
         
        }
        public void addAdministrator(Administrator administrator)
        {
            foreach (var item in db.Administrators)
            {
                if (item.ID==administrator.ID)
                {
                    throw new Exception("administrator  exsists already");
                }
            }
            db.Administrators.Add(administrator);
            db.SaveChanges();
        }
        public void deleteAdministrator(int id)
        {
            var admin = (from item in db.Administrators.ToList()
                         where (item.ID == id)
                         select item).FirstOrDefault();
            if (admin == null)
            {
                throw new Exception("administrator dosn't exsist");
            }
            else
            {
                db.Administrators.Remove(admin);
                db.SaveChanges();
            }
        }
      
        
        public IEnumerable<Administrator> getAllAdministrators()
        {
            return db.Administrators.ToList();
        }

        //////////Doctor//////////////////////
        public void UpdateDoctor(Doctor doctor)
        {
            var doc = (from item in db.Doctors.ToList()
                         where (item.ID == doctor.ID)
                         select item).FirstOrDefault();
            if (doc == null)
            {
                throw new Exception("doctor dosn't exsist");
            }
            else
            {
                db.Doctors.Remove(doc);
                db.Doctors.Add(doctor);
                db.SaveChanges();
            }
        }
        public void AddDoctor(Doctor doctor)
        {
            var item = (from n in db.Doctors
                        where n.ID == doctor.ID
                        select n).FirstOrDefault();
            if (item==null)
            {
                db.Doctors.Add(doctor);
                db.SaveChanges();
            }
            else throw new Exception("doctor  exsists already");

        }
        public void deleteDoctor(int id)
        {
            var d = (from item in db.Doctors
                     where item.ID == id
                     select item).FirstOrDefault();
            if(d==null)
                throw new Exception("doctor dosn't exsist");
            else
            {
                db.Doctors.Remove(d);
                db.SaveChanges();
            }
        }
        
        public IEnumerable<Doctor> getAllDoctors()
        {
            return db.Doctors.ToList();
        }

        ///////////Medicine////////////////
        public void UpdateMedicine(Medicine medicine)
        {
            var med = (from item in db.Medicines.ToList()
                         where (item.ID == medicine.ID)
                         select item).FirstOrDefault();
            if (med == null)
            {
                throw new Exception("Medicine dosn't exsist");
            }
            else
            {
                db.Medicines.Remove(med);
                db.Medicines.Add(medicine);
                db.SaveChanges();
            }
        }
        public void AddMedicine(Medicine medicine)
        {
            if (db.Medicines.ToList().Exists(item => item.ID == medicine.ID) == false)
            {
                db.Medicines.Add(medicine);
                db.SaveChanges();
            }
            throw new Exception("Medicine  exsist already");
        }
        public void  deleteMediciner(int id)
        {
            var m = (from item in db.Medicines
                     where item.ID == id
                     select item).FirstOrDefault();
            if (m == null)
                throw new Exception("medicine dosn't exsist");
            else
            {
                db.Medicines.Remove(m);
                db.SaveChanges();
            }

        }
        public IEnumerable<Medicine> getAllMedicines()
        {
            return db.Medicines.ToList(); 
        }

        //////////Patient////////////////
        public void UpdatePatient(Patient patient)
        {
            PharmacyContext db = new PharmacyContext();
            var pat = (from item in db.Patients.ToList()
                       where (item.ID == patient.ID)
                       select item).FirstOrDefault();
            if (pat== null)
            {
                throw new Exception("Patient dosn't exsist");
            }
            else
            {
                db.Patients.Remove(pat);
                db.Patients.Add(patient);
                db.SaveChanges();
            }
        }
        public void  AddPatient(Patient patient)
        {
            if (db.Patients.ToList().Exists(item => item.ID == patient.ID) == false)
            {
                db.Patients.Add(patient);
                db.SaveChanges();
            }
            throw new Exception("Patient  exsists already");
        }
        public void  deletePatient(int id)
        {
            var p = (from item in db.Patients
                     where item.ID == id
                     select item).FirstOrDefault();
            if (p == null)
                throw new Exception("patient dosn't exsist");
            else
            {
                db.Patients.Remove(p);
                db.SaveChanges();
            }
        }

        public IEnumerable<Patient> getAllPatients()
        {
            return db.Patients.ToList();
        }

        /////////////////Prescription//////////
        public void AddPrescription(Prescription prescription)
        {
            if (db.Prescriptions.ToList().Exists(item => item.ID == prescription.ID) == false)
            {
                db.Prescriptions.Add(prescription);
                db.SaveChanges();
            }
            throw new Exception("Prescription exsists already");
        }
        public IEnumerable<Prescription> getAllPrescriptions()
        {
            return db.Prescriptions.ToList(); 
        }
    }
    public class PharmacyContext : DbContext
    {

        public PharmacyContext() : base()
        {
        }

        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Administrator> Administrators { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }

}
