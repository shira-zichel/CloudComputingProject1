using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    public class Patient
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public List<Prescription> Prescriptions { get; set; }
        public override string ToString()
        {
            return $"id:{ID} firstname:{FirstName} LastName{LastName}";
        }
    }
}
