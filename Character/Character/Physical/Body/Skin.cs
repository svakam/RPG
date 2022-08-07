using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character.Physical.Body
{
    public class Skin
    {
        public decimal TanLevel { get; set; }
    }
    
    public enum SkinType
    {
        TypeI,
        TypeII,
        TypeIII,
        TypeIV,
        TypeV,
        TypeVI
    }
}
