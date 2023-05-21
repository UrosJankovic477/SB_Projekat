using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZelenePovrsine.Entities
{
    public class Igraliste : Objekat
    {
        public virtual int BrIgracaka { get; set; }
        public virtual int GodineOd { get; set; } = 0;
        public virtual int? GodineDo { get; set; } = null;
        public virtual string ImaPesak { get; set; }
    }
}
