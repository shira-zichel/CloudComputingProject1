using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
     public class Prescription
    {
        public string ID { get; set; }
        public List<Medicine> Medicines { get; set; }
        public float amount { get; set; }
        public int period { get; set; }
        public DateTime StartData { get; set; }
        public DateTime EndData { get; set; }
        public Doctor ReferringDoctor { get; set; }
    }
}
