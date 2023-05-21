using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZelenePovrsine.Entities;
using FluentNHibernate.Mapping;

namespace ZelenePovrsine.Mappings
{
    internal class IgralisteMap : SubclassMap<Igraliste>
    {
        IgralisteMap()
        {
            Table("IGRALISTE");

            KeyColumn("BR_OBJ");

            Map(p => p.GodineOd).Column("GODINE_OD");
            Map(p => p.GodineDo).Column("GODINE_DO");
            Map(p => p.BrIgracaka).Column("BR_IGRACAKA");
            Map(p => p.ImaPesak).Column("PESAK");
        }
    }
}
