
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
        public string ID { get; set; }
        public DateTime ExpirationDate { get; set; }

        public override string ToString()
        {
            return $"id:{ID} name:{Name} WorkPlace:{WorkPlace}";
        }
    }
}
