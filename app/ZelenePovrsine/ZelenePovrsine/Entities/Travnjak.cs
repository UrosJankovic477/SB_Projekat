using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZelenePovrsine.Entities
{
    public class Travnjak : ZelenaPovrsina
    {
        public virtual string AdresaZgrade { get; set; }
        public virtual float PovrsinaAri { get; set; } = 0;
    }
}
