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
        void deleteAdministrator(Administrator administrator) 
        {
            dal.deleteAdministrator(administrator);
        }
        IEnumerable<Administrator> getAllAdministrators()
        {
            return dal.getAllAdministrators(); 
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
        void deleteDoctor(Doctor doctor) 
        {
            try
            {
                dal.deleteDoctor(doctor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
        void deleteMediciner(Medicine medicine) 
        {
            try
            {
                dal.deleteMediciner(medicine);
            }
            catch (Exception ex)
            {

                throw ex;
            }
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
        void deletePatient(Patient patient)
        {
            try
            {
                dal.deletePatient(patient);
            }
            catch (Exception ex)
            {

                throw ex;
            }
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
        IEnumerable<Prescription> getAllPrescriptions()
        { 
            return dal.getAllPrescriptions(); 
        }
    }
}
