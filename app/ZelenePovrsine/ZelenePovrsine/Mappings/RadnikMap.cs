using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZelenePovrsine.Entities;
using FluentNHibernate.Mapping;

namespace ZelenePovrsine.Mappings
{
    internal class AbstractRadnikMap : ClassMap<Radnik>
    {
        AbstractRadnikMap()
        {
            Table("RADNIK");

            Id(p => p.BrRK, "BR_RAD_KNJIZICE").GeneratedBy.TriggerIdentity();


            

            Map(p => p.Mbr).Column("MBR");
            Map(p => p.StrucnaSprema).Column("STRUCNA_SPREMA");
            Map(p => p.Ime).Column("LIME");
            Map(p => p.ImeRoditelja).Column("SIME");
            Map(p => p.Prezime).Column("PREZIME");
            Map(p => p.DatumRodjenja).Column("DAT_RODJENJA");
            Map(p => p.Adresa).Column("ADRESA");
            Map(p => p.OdrzavaZelenila).Column("ODRZAVA_ZELENILA");
            Map(p => p.OdrzavaHigijenu).Column("ODRZAVA_HIGIJENU");
            Map(p => p.OdrzavaObjekte).Column("ODRZAVA_OBJ_PARKA");
        }
    }
}
