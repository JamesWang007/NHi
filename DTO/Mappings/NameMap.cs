using FluentNHibernate.Mapping;
using NHibernate.Mapping.ByCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Commencement_Mvc_Data.DTO.Mappings{
    class NameMap  : ClassMap<Name> {

        public NameMap() {
            Id(x => x.Id, "UNIQUE_ID");
            Map(p => p.Emplid, "EMPLID");
            Map(p => p.LastName, "LAST_NAME");
            Map(p => p.FirstName, "FIRST_NAME");
            Table("NAME_VIEW");
            SchemaAction.None();
        }
    }
}
