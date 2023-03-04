using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarPanelAppWF
{
    class Part
    {
        public int partId { get; set; }
        public string name { get; set; }
        public double unitPrice { get; set; }
        public int sum { get; set; }
        public int maxPerStorage { get; set; }
        public int errorCode { get; set; }
    }
}
