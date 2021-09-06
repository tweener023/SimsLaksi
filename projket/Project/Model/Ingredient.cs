using System;

namespace Model
{
   public class Ingredient
   {
        public Ingredient(string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }

        public String Name
        {
            get
            ;
            set
            ;
        }
        public String Description
        {
            get
            ;
            set
            ;
        }

        public int CountInMedicines
        {
            get
            ;
            set
            ;
        }
    }
}
