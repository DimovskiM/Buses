using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Lines
    {
        String Time {get; set;}
        String Destination { get; set; }
        public int Price { get; set; }

        public Lines() {
            Time = "";
            Destination = "";
            Price = 0;
        
        
        }
        public Lines(String Time, String Destination, int Price) {

            this.Time = Time;
            this.Destination = Destination;
            this.Price = Price;
        }
        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} Ден.", Time, Destination, Price);
        }
        
    }
}
