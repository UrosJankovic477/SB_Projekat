using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZelenePovrsine.Entities;
using FluentNHibernate.Mapping;

namespace ZelenePovrsine.Mappings
{
    internal class ZasticeniObjekatMap : ClassMap<ZasticeniObjekat>
    {
        ZasticeniObjekatMap()
        {
            Table("ZASTICENI_OBJ");

            Id(p => p.Id, "ZASTICENI_OBJ_ID").GeneratedBy.TriggerIdentity();

            Map(p => p.Opis).Column("OPIS");
            Map(p => p.OdgovornaInstitucija).Column("INSTITUCIJA");
            Map(p => p.DatumStavljanjaPodZastitu).Column("DAT_STAVLJANJA_POD_ZASTITU");
            Map(p => p.GodisnjiTroskovi).Column("GOD_TROSKOVI");
        }

    }
}
