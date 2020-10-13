using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BE;

namespace CloudComputingProject1.Models
{
    public class DoctorModel
    {
        public List<DoctorModelClass> Doctors { get; set; }
        public DoctorModel()
        {
            this.Doctors = new List<DoctorModelClass>
            {
                new DoctorModelClass
                {
                      Name ="fhfh",
          Specialization ="fhfh",
          WorkPlace ="fhfh",
          ID =1,
          Phone =125,
          MailAddress ="fhfh",
          License=new DoctorLicense(){LicenseID=2,ExpirationDate=DateTime.Now},
          PicturePath=@"/img/t2.jpg"
    },
      new DoctorModelClass
                {
                      Name ="fhfh",
          Specialization ="fhfh",
          WorkPlace ="fhfh",
          ID =2,
          Phone =125,
          MailAddress ="fhfh",
          License=new DoctorLicense(){LicenseID=2,ExpirationDate=DateTime.Now},
         PicturePath=@"/img/t3.jpg"

    },
      new DoctorModelClass
                {
                      Name ="fhfh",
          Specialization ="fhfh",
          WorkPlace ="fhfh",
          ID =3,
          Phone =125,
          MailAddress ="fhfh",
          License=new DoctorLicense(){LicenseID=2,ExpirationDate=DateTime.Now},
                   PicturePath=@"/img/t1.jpg"

    },
      new DoctorModelClass
                {
                      Name ="fhfh",
          Specialization ="fhfh",
          WorkPlace ="fhfh",
          ID =4,
          Phone =125,
          MailAddress ="fhfh",
          License=new DoctorLicense(){LicenseID=2,ExpirationDate=DateTime.Now},
                   PicturePath=@"/img/t4.jpg"

    }
            };
        }
        public List<DoctorModelClass> GetDoctors()
        {
            return this.Doctors;
        }
        public DoctorModelClass GetDoctor(int id)
        {
            //var result = (from f in Medicines
            //              where f.ID == id
            //              select f).Single<Medicine>();
            return this.Doctors.Where(w => w.ID == id).FirstOrDefault();
        }
        public void addDoctors(DoctorModelClass d)
        {
            this.Doctors.Add(d);
        }
    }

}
