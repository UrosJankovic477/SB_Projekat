using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZelenePovrsine.Entities;
using FluentNHibernate.Mapping;

namespace ZelenePovrsine.Mappings
{
    internal class ZelenaPovrsinaMap : ClassMap<ZelenaPovrsina>
    {
        ZelenaPovrsinaMap()
        {
            Id(p => p.Id, "BROJ").GeneratedBy.TriggerIdentity();

            Map(p => p.UgrozenostOdZagadjenja).Column("UGROZENOST");
            Map(p => p.Opstina).Column("OPSTINA");

            UseUnionSubclassForInheritanceMapping();
        }
    }
}
