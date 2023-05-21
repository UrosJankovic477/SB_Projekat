using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZelenePovrsine.Entities
{
    public class RadnikParkId
    {
        public virtual Radnik Radnik { get; set; }
        public virtual Park Park { get; set; }
        public virtual DateTime DatumOd { get; set; }

        public override bool Equals(object obj)
        {
            if(Object.ReferenceEquals(this, obj))
            {
                return true;
            }
            if(obj.GetType() != typeof(RadnikParkId))
            {
                return false;
            }
            RadnikParkId recievedObject = (RadnikParkId)obj;
            if(this.Radnik.BrRK == recievedObject.Radnik.BrRK &&
                this.Park.Id == recievedObject.Park.Id &&
                this.DatumOd == recievedObject.DatumOd)
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
