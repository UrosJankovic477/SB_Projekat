using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZelenePovrsine.Entities
{
    public class Park : ZelenaPovrsina
    {
        public virtual string Naziv { get; set; }
        public virtual float Povrsina_hektari { get; set; }
        public virtual IList<Objekat> Objekti { get; set; }
        public Park()
        {
            Objekti = new List<Objekat>();
        }
    }
}
