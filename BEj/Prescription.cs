using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
     public class Prescription
    {
        public int ID { get; set; }
        public string DragName { get; set; }
        public float amount { get; set; }
        public int period { get; set; }
    }
}
