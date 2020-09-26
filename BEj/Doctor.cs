
using System;
using System.Collections.Generic;
using System.Text;



namespace BE
{
    public class Doctor
    {
        public string Name { get; set; }
        public int age { get; set; }
        public string WorkPlace { get; set; }
        public int ID { get; set; }
        public DoctorLicense License { get; set; }

        public override string ToString()
        {
            return $"id:{ID} name:{Name} WorkPlace:{WorkPlace}";
        }
    }
}
