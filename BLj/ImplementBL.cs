using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BE;

namespace BL
{
    public class ImplementBL
    {
        DAL.ImplementDAL dal = new DAL.ImplementDAL();
        ///////////////Administrator//////////////
        public void UpdateAdministrator(Administrator administrator)
        {
            try
            {
                dal.UpdateAdministrator(administrator);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void addAdministrator(Administrator administrator)
        {
            try
            {
                dal.addAdministrator(administrator);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void deleteAdministrator(string id)
        {
            dal.deleteAdministrator(id);
        }
        public IEnumerable<Administrator> getAllAdministrators()
        {
            return dal.getAllAdministrators();
        }
        public void isAdministrator(string code)
        {
            if (code != "12345")
            {
                throw new Exception("incorrect code");
            }

        }

        //////////Doctor//////////////////////
        public void UpdateDoctor(Doctor doctor)
        {
            try
            {
                dal.UpdateDoctor(doctor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void AddDoctor(Doctor doctor)
        {
            try
            {
                dal.AddDoctor(doctor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void deleteDoctor(string id)
        {
            try
            {
                dal.deleteDoctor(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Doctor getDoctor(string id)
        {
            Doctor d = (from item in dal.getAllDoctors().ToList()
                        where item.ID == id
                        select item).FirstOrDefault();
            if (d != null)
                return d;
            else
                throw new Exception("doctor doesn't exist");
        }
        public IEnumerable<Doctor> getAllDoctors()
        {
            return dal.getAllDoctors();
        }

        ///////////Medicine////////////////
        public void UpdateMedicine(Medicine medicine)
        {
            try
            {
                dal.UpdateMedicine(medicine);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void AddMedicine(Medicine medicine)
        {
            try
            {
                dal.AddMedicine(medicine);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void deleteMediciner(string id)
        {
            try
            {
                dal.deleteMediciner(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public Medicine GetMedicine(string id)
        {
            Medicine m = (from item in dal.getAllMedicines().ToList()
                          where item.ID == id
                          select item).FirstOrDefault();
            if (m != null)
                return m;
            else
                throw new Exception("medicine doesn't exist");
        }
        public IEnumerable<Medicine> getAllMedicines()
        {
            return dal.getAllMedicines();
        }

        //////////Patient////////////////
        public void UpdatePatient(Patient patient)
        {
            try
            {
                dal.UpdatePatient(patient);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void AddPatient(Patient patient)
        {
            try
            {
                dal.AddPatient(patient);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void deletePatient(string id)
        {
            try
            {
                dal.deletePatient(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Patient GetPatient(string id)
        {
            Patient p = (from item in dal.getAllPatients().ToList()
                         where item.ID == id
                         select item).FirstOrDefault();
            if (p != null)
                return p;
            else
                throw new Exception("patient doesn't exist");
        }
        public List<Prescription> PatientPrescriptions(string id)
        {
            var patient = (from item in dal.getAllPatients().ToList()
                           where item.ID == id
                           select item).FirstOrDefault();
            return patient.Prescriptions;
        }
        public IEnumerable<Patient> getAllPatients()
        {
            return dal.getAllPatients();
        }

        /////////////////Prescription//////////
        public void AddPrescription(Prescription prescription)
        {
            if (prescription.ReferringDoctor.License.ExpirationDate.Date < DateTime.Today.Date)
            {
                throw new Exception("Invalid doctor license");
            }
            //check if the medicines don't conflict

            //more checking
            try
            {
                dal.AddPrescription(prescription);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public Prescription GetPrescription(string id)
        {
            Prescription p = (from item in dal.getAllPrescriptions().ToList()
                              where item.ID == id
                              select item).FirstOrDefault();
            if (p != null)
                return p;
            else
                throw new Exception("prescription doesn't exist");
        }
        public IEnumerable<Prescription> getAllPrescriptions()
        {
            return dal.getAllPrescriptions();
        }
        public int MedicinePerPeriod(string medicine,DateTime startDate,DateTime endDate)
        {
            int sum = 0;
            foreach (var item in dal.getAllPrescriptions())
            {
                if (item.StartData >= startDate && item.StartData <= endDate && item.Medicines.Exists(m=>m.Name==medicine))
                    sum += 1;
            }
            return sum;
        }
    }
}
