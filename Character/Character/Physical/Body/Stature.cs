using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character.Physical.Body
{
    public class Stature
    {
        public decimal Height { get; set; }
    }

    public enum Posture
    {
        STRAIGHT,
        PROPER,
        ABOVEAVG,
        AVERAGE,
        BELOWAVG,
        SLOUCHED,
        HUNCHBACK
    }
}
