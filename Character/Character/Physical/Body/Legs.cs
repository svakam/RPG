using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character.Physical.Body
{
    public class Legs
    {
        public decimal LegStrength { get; set; }
        public decimal LegFlexibility { get; set; }
    }

    public enum LegHair
    {
        HAIRY,
        MILDHAIRY,
        AVERAGE,
        LESSHAIRY,
        NONE
    }

    public enum LegLength
    {
        LONG,
        AVERAGE,
        SHORT
    }
}
