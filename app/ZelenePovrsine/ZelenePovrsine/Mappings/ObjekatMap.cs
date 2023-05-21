using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZelenePovrsine.Entities;
using FluentNHibernate.Mapping;

namespace ZelenePovrsine.Mappings
{
    internal class ObjekatMap : ClassMap<Objekat>
    {
        ObjekatMap()
        {
            Id(p => p.Id, "BR_OBJ").GeneratedBy.TriggerIdentity();

            References(p => p.Park).Column("BR_PARKA").LazyLoad();

            UseUnionSubclassForInheritanceMapping();
        }
    }
    internal class FontanaMap : SubclassMap<Fontana>
    {
        FontanaMap()
        {
            Table("FONTANA");
        }
    }
    internal class SvetiljkaMap : SubclassMap<Svetiljka>
    {
        SvetiljkaMap()
        {
            Table("SVETILJKA");
        }
    }
    internal class KlupaMap : SubclassMap<Klupa>
    {
        KlupaMap()
        {
            Table("KLUPA");
        }
    }

}
