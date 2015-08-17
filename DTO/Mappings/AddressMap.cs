using FluentNHibernate.Mapping;
using NHibernate.Mapping.ByCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Commencement_Mvc_Data.DTO.Mappings{
    class AddressMap  : ClassMap<Address> {

        public AddressMap() {
            Id(x => x.Id, "UNIQUE_ID");
            Map(p => p.Emplid, "EMPLID");
            Map(p => p.Address1, "ADDRESS1");
            Map(p => p.Address2, "ADDRESS2");
            Map(p => p.City, "CITY");
            Map(p => p.State, "STATE");
            Map(p => p.PostalZip, "POSTAL_ZIP");
            Map(p => p.Phone, "PHONE");
            Map(p => p.EmailAddress, "EMAIL_ADDRESS");
            Table("ADDRESS_VIEW");
            SchemaAction.None();
        }
    }
}
