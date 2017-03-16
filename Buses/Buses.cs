using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Buses
    {
        String Name { get; set; }
        String Licence { get; set; }
        bool isLocal { get; set; }
public List<Lines> listLines;
        public Buses(String Name,String Licence,bool isLocal) {
            this.Name = Name;

            this.Licence = Licence;
            this.isLocal = isLocal;
            listLines = new List<Lines>();

        
        }

        public void addLine(Lines line)
        {
            if (!listLines.Contains(line)) {
                listLines.Add(line); 
            }
        }
        public Lines mostExpensiveLine() {
            Lines line = new Lines();
            foreach (Lines l in listLines) {
                if (line.Price < l.Price)
                {
                    line = l;
                }
            }
            return line;
        }
        public float averagePriceOfLines() {
            float Average = 0;
            foreach (Lines l in listLines)
            {
                Average += l.Price;
            }
            return Average / listLines.Count;
        }
        public override string ToString()
        {
            return String.Format("{0} - {1} - {2}", Name,Licence,isLocal?"L":"N");
        }

    }
}
