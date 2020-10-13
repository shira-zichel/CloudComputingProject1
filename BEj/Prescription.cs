using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
     public class Prescription
    {
        public int ID { get; set; }
        public string PatientName { get; set; }
        public int PatientId { get; set; }
        public string MedicineName { get; set; }
        public int MedicineId { get; set; }
        public float amount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Doctor ReferringDoctor { get; set; }
    }
}
