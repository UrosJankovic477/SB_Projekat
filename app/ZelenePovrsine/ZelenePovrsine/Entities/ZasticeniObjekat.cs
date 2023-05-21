using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZelenePovrsine.Entities
{
    public class ZasticeniObjekat
    {
        public virtual int Id { get; set; }
        public virtual string Opis { get; set; }
        public virtual string OdgovornaInstitucija { get; set; }
        public virtual DateTime DatumStavljanjaPodZastitu { get; set; }
        public virtual int GodisnjiTroskovi { get; set; }
    }
}
