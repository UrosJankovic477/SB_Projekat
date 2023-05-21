using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZelenePovrsine.Entities;
using FluentNHibernate.Mapping;

namespace ZelenePovrsine.Mappings
{
    internal class ParkMap : SubclassMap<Park>
    {
        ParkMap()
        {
            Table("PARK");

            KeyColumn("BROJ");

            Map(p => p.Naziv).Column("NAZIV");
            Map(p => p.Povrsina_hektari).Column("POVRSINA_HA");

            HasMany(p => p.Objekti).KeyColumn("BR_PARKA").Cascade.All().Inverse();
        }
    }
}
