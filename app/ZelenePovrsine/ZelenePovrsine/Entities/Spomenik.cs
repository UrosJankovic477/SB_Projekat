using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZelenePovrsine.Entities
{
    public class Spomenik : Objekat
    {
        public virtual ZasticeniObjekat ZasticeniObjekat { get; set; }
    }
}
