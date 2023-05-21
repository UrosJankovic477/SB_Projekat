using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZelenePovrsine.Entities;
using FluentNHibernate.Mapping;

namespace ZelenePovrsine.Mappings
{
    internal class TravnjakMap : SubclassMap<Travnjak>
    {
        TravnjakMap()
        {
            Table("TRAVNJAK");

            KeyColumn("BROJ");

            Map(p => p.PovrsinaAri).Column("POVRSINA_A");
            Map(p => p.AdresaZgrade).Column("ADRESA_ZGRADE");
        }
    }
}
