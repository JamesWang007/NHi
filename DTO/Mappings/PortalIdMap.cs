using FluentNHibernate.Mapping;
using NHibernate.Mapping.ByCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Commencement_Mvc_Data.DTO.Mappings{
    class PortalIdMap  : ClassMap<PortalId> {

        public PortalIdMap() {
            Id(x => x.Emplid, "EMPLID");
            Map(p => p.UserId, "USER_ID");
            Map(p => p.Initialized, "INITIALIZED");
            Map(p => p.CepId, "CEPID");
            Table("RDSPRD.PORTALID_XWALK@PUBLIC_FRONT1");
            SchemaAction.None();
        }
    }
}
