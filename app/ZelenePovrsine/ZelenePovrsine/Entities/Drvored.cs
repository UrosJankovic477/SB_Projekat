using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZelenePovrsine.Entities
{
    public class Drvored : ZelenaPovrsina
    {
        public virtual string Ulica { get; set; }
        public virtual string VrstaDrveta { get; set; }
        public virtual int BrStabala { get; set; } = 0;

    }
}
