using FluentNHibernate.Mapping;
using NHibernate.Mapping.ByCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Commencement_Mvc_Data.DTO.Mappings{
    class CommencementTermMap  : ClassMap<CommencementTerm> {

        public CommencementTermMap() {
            Id(x => x.Term, "COMMENCEMENT_TERM");
            Map(p => p.CommencementTermLdesc, "COMMENCEMENT_TERM_LDESC");
            Map(p => p.BeginDt, "BEGIN_DT");
            Map(p => p.EndDt, "END_DT");
            Table("ALM_COMMENCEMENT_TERM");
            SchemaAction.None();
        }
    }
}
