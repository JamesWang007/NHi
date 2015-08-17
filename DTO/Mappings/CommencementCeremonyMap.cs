using FluentNHibernate.Mapping;
using NHibernate.Mapping.ByCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Commencement_Mvc_Data.DTO.Mappings{
    class CommencementCeremonyMap  : ClassMap<CommencementCeremony> {

        public CommencementCeremonyMap() {
            Id(x => x.College, "COLLEGE");
            Map(p => p.Ceremony, "CEREMOMY");   //Yes, with an M
            Map(p => p.MaxTicketsAllowed, "MAX_TICKETS_ALLOWED");
            Table("TEST_ALM_COMMENCEMENT_CEREMONY");
            SchemaAction.None();
        }
    }
}
