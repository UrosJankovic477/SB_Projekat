using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZelenePovrsine.Entities;
using FluentNHibernate.Mapping;

namespace ZelenePovrsine.Mappings
{
    internal class SefParkMap : ClassMap<SefPark>
    {
        SefParkMap()
        {
            Table("SEF_PARK");

            CompositeId(p => p.Id)
                .KeyReference(p => p.Sef, "SEFID")
                .KeyReference(p => p.Park, "PARKID")
                .KeyProperty(p => p.DatumOd, "DATUM_OD");

            Map(p => p.DatumDo).Column("DATUM_DO");
        }
    }
}
