using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    public class Doctor
    {
        public string Name { get; set; }
        public string Specialization { get; set; }
        public string WorkPlace { get; set; }
        public long ID { get; set; }
        public long Phone { get; set; }
        public string MailAddress { get; set; }
        public DoctorLicense License { get; set; }
        public override string ToString()
        {
            return $"id:{ID} name:{Name} WorkPlace:{WorkPlace}";
        }
    }
}
