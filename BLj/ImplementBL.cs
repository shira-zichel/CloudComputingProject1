using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BL
{
    public class ImplementBL
    {
        DAL.ImplementDAL dal = new DAL.ImplementDAL();
        ///////////////Administrator//////////////
        void UpdateAdministrator(Administrator administrator)
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
        void addAdministrator(Administrator administrator)
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
        void deleteAdministrator(int id) 
        {
            dal.deleteAdministrator(id);
        }
        IEnumerable<Administrator> getAllAdministrators()
        {
            return dal.getAllAdministrators(); 
        }
        void isAdministrator(string code)
        {
            if (code != "12345")
            {
              throw new Exception("incorrect code");
            }
         
        }

        //////////Doctor//////////////////////
        void UpdateDoctor(Doctor doctor)
        {
            try
            {
                dal.UpdateDoctor(doctor);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        void AddDoctor(Doctor doctor)
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
        void deleteDoctor(int id) 
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
       
        Doctor getDoctor(int id)
        {
            Doctor d = (from item in dal.getAllDoctors().ToList()
                        where item.ID == id
                        select item).FirstOrDefault();
            if (d != null)
                return d;
            else
                throw new Exception("doctor doesn't exist");
        }
        IEnumerable<Doctor> getAllDoctors()
        {
            return dal.getAllDoctors(); 
        }

        ///////////Medicine////////////////
        void UpdateMedicine(Medicine medicine)
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
        void AddMedicine(Medicine medicine)
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
        void deleteMediciner(int id) 
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
        Medicine GetMedicine(int id)
        {
            Medicine m= (from item in dal.getAllMedicines().ToList()
                        where item.ID == id
                        select item).FirstOrDefault();
            if (m != null)
                return m;
            else
                throw new Exception("medicine doesn't exist");
        }
        IEnumerable<Medicine> getAllMedicines() 
        { 
            return dal.getAllMedicines(); 
        }

        //////////Patient////////////////
        void UpdatePatient(Patient patient)
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
        void AddPatient(Patient patient)
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
        void deletePatient(int id)
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
       
        Patient GetPatient(int id)
        {
            Patient p = (from item in dal.getAllPatients().ToList()
                          where item.ID == id
                          select item).FirstOrDefault();
            if (p != null)
                return p;
            else
                throw new Exception("patient doesn't exist");
        }
        List<Prescription> PatientPrescriptions(int id)
        {
           var patient = (from item in dal.getAllPatients().ToList()
                               where item.ID == id
                               select item).FirstOrDefault();
           return patient.Prescriptions;
        }
        IEnumerable<Patient> getAllPatients()
        {
            return dal.getAllPatients();
        }

        /////////////////Prescription//////////
        void AddPrescription(Prescription prescription)
        { 
            if(prescription.ReferringDoctor.License.ExpirationDate.Date<DateTime.Today.Date)
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
        Prescription GetPrescription(int id)
        {
            Prescription p = (from item in dal.getAllPrescriptions().ToList()
                          where item.ID == id
                          select item).FirstOrDefault();
            if (p != null)
                return p;
            else
                throw new Exception("prescription doesn't exist");
        }
        IEnumerable<Prescription> getAllPrescriptions()
        { 
            return dal.getAllPrescriptions(); 
        }
    }
}
