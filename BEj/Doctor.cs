using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    public class Doctor
    {
        public string Name { get; set; }
        public string specialization { get; set; }
        public string WorkPlace { get; set; }
        public long ID { get; set; }
        public long Phone { get; set; }
        public string MailAddress { get; set; }

        //*****************למחוק*******************
        
        //*****************************
        public override string ToString()
        {
            return $"id:{ID} name:{Name} WorkPlace:{WorkPlace}";
        }
    }
}
