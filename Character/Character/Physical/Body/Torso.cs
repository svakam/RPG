using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character.Physical.Body
{
    public class Torso
    {
        public decimal TorsoFlexibility { get; set; }
    }

    public enum TorsoStrength
    {
        VERYSTRONG,
        STRONG,
        AVERAGE,
        WEAK,
        VERYWEAK
    }
}
