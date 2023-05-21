using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZelenePovrsine.Entities
{
    public abstract class Objekat
    {
        public virtual int Id { get; set; }
        public virtual Park Park { get; set; }
    }
    public class Fontana : Objekat
    {

    }
    public class Svetiljka : Objekat
    {

    }
    public class Klupa : Objekat
    {

    }
}
