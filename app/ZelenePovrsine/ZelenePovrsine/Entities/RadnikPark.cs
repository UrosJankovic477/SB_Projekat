using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZelenePovrsine.Entities
{
    public class RadnikPark
    {
        public virtual RadnikParkId Id { get; set; }
        public virtual DateTime? DatumDo { get; set; }
    }
}
