using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZelenePovrsine.Entities;
using FluentNHibernate.Mapping;

namespace ZelenePovrsine.Mappings
{
    internal class DrvoMap : SubclassMap<Drvo>
    {
        public DrvoMap()
        {
            Table("DRVO");

            KeyColumn("BR_OBJ");

            Map(p => p.Vrsta).Column("VRSTA");
            Map(p => p.VisinaKrosnje).Column("VISINA_KROSNJE");
            Map(p => p.ObimDebla).Column("OBIM_DEBLA");
            Map(p => p.PovrsinaKrosnje).Column("POVRSINA_KROSNJE");
            Map(p => p.DatumSadjenja).Column("DAT_SADJENJA");

            References(p => p.ZasticeniObjekat).Column("ZASTICENI_OBJ_ID");
        }
    }
}
