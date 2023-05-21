using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZelenePovrsine.Entities
{
    public class Radnik
    {
        public virtual int BrRK { get; set; }
        public virtual string Mbr { get; set; }
        public virtual string Adresa { get; set; }
        public virtual string StrucnaSprema { get; set; }
        public virtual DateTime DatumRodjenja { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual string ImeRoditelja { get; set; }
        public virtual int OdrzavaZelenila { get; set; }
        public virtual int OdrzavaHigijenu { get; set; }
        public virtual int OdrzavaObjekte { get; set; }
    }
}
