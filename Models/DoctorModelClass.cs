using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BE;
namespace CloudComputingProject1.Models
{
    public class DoctorModelClass
    {
        public string Name { get; set; }
        public string Specialization { get; set; }
        public string WorkPlace { get; set; }
        public long ID { get; set; }
        public long Phone { get; set; }
        public string MailAddress { get; set; }
        public DoctorLicense License { get; set; }
        public string PicturePath { get; set; }


    }
    
}