using FluentNHibernate.Mapping;
using NHibernate.Mapping.ByCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Commencement_Mvc_Data.DTO.Mappings{
    class MajorMap  : ClassMap<Major> {

        public MajorMap() {
            Id(x => x.AcadPlan, "ACAD_PLAN");
            Map(p => p.AcadPlanType, "ACAD_PLAN_TYPE");
            Map(p => p.AcadPlanLdesc, "ACAD_PLAN_LDESC");
            Map(p => p.AcadDegree, "DEGREE");
            Map(p => p.AcadCollege, "COLLEGE");
            Map(p => p.AcadCeremony, "CEREMONY");
            Table("MAJOR_VIEW");
            SchemaAction.None();
        }
    }
}
