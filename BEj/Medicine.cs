using System;

namespace BE
{
    public class Medicine
    {
        public string Name { get; set; }
        public string Producer { get; set; }
        public string GenericName { get; set; }
        public string ActiveIngredients { get; set; }
        public string DoseCharacteristics { get; set; }
        public int ID { get; set; }
        public override string ToString()
        {
            return $"id:{ID} name:{Name}";
        }
    }
}
