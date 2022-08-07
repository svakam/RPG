using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character.Physical.Body
{
    public class Arms
    {
        public decimal ArmStrength { get; set; }
        public decimal ArmFlexibility { get; set; }
    }

    public enum ArmHair
    {
        HAIRY,
        MILDHAIRY,
        AVERAGE,
        LESSHAIRY,
        NONE
    }

    public enum ArmLength
    {
        LONG,
        AVERAGE,
        SHORT
    }

}
