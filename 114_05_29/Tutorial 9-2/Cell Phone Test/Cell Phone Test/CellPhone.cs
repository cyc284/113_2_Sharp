using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cell_Phone_Test
{
    class CellPhone
    {
        private string brand;
        private string model;
        private decimal price; // Corrected type to match the property  

        public CellPhone()
        {
            brand = "";
            model = "";
            price = 0; // Corrected initialization  
        }

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public decimal Price // Removed duplicate property definition  
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be negative.");
                }
                price = value;
            }
        }
    }
}
