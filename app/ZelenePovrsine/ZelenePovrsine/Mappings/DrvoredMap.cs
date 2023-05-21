using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZelenePovrsine.Entities;
using FluentNHibernate.Mapping;

namespace ZelenePovrsine.Mappings
{
    internal class DrvoredMap : SubclassMap<Drvored>
    {
        DrvoredMap()
        {
            Table("DRVORED");

            KeyColumn("BROJ");

            Map(p => p.VrstaDrveta).Column("VRSTA_DRVETA");
            Map(p => p.BrStabala).Column("BR_STABALA");
            Map(p => p.Ulica).Column("ULICA");
        }
    }
}
