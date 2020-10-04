﻿using System;
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
        public void deleteAdministrator(Administrator administrator) 
        {
            dal.deleteAdministrator(administrator);
        }
        IEnumerable<Administrator> getAllAdministrators()
        {
            return dal.getAllAdministrators(); 
        }

        //////////Doctor//////////////////////
        public void UpdateDoctor(Doctor doctor)
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
        public void deleteDoctor(Doctor doctor) 
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
        public void deleteMediciner(Medicine medicine) 
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
        public void deletePatient(Patient patient)
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
        public IEnumerable<Patient> getAllPatients()
        {
            return dal.getAllPatients();
        }

        /////////////////Prescription//////////
        public void AddPrescription(Prescription prescription)
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
        public IEnumerable<Prescription> getAllPrescriptions()
        { 
            return dal.getAllPrescriptions(); 
        }
    }
}