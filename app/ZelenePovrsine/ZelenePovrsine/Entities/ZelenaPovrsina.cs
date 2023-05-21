using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZelenePovrsine.Entities
{
    public abstract class ZelenaPovrsina
    {
        public virtual int Id { get; set; }
        public virtual string UgrozenostOdZagadjenja { get; set; }
        public virtual string Opstina { get; set; }
        
    }
}
