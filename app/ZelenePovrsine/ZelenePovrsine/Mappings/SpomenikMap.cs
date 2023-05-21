using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZelenePovrsine.Entities;
using FluentNHibernate.Mapping;

namespace ZelenePovrsine.Mappings
{
    internal class SpomenikMap : SubclassMap<Spomenik>
    {
        SpomenikMap()
        {
            Table("SPOMENIK");

            KeyColumn("BR_OBJ");

            References(p => p.ZasticeniObjekat).Column("ZASTICENI_OBJ_ID");
        }
    }
}
