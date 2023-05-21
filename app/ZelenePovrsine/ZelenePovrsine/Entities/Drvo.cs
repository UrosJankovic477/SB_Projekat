using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZelenePovrsine.Entities
{
    public class Drvo : Objekat
    {
        public virtual string Vrsta { get; set; }
        public virtual DateTime DatumSadjenja { get; set; }
        public virtual float VisinaKrosnje { get; set; }
        public virtual float PovrsinaKrosnje { get; set; }
        public virtual float ObimDebla { get; set; }
        public virtual ZasticeniObjekat? ZasticeniObjekat { get; set; }
    }
}
