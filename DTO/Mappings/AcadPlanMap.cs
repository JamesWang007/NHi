using FluentNHibernate.Mapping;
using NHibernate.Mapping.ByCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Commencement_Mvc_Data.DTO.Mappings{
    class AcadPlanMap  : ClassMap<AcadPlan> {

        public AcadPlanMap() {
            Id(p => p.Id, "UNIQUE_ID");
            Map(p => p.Emplid, "EMPLID");
            Map(p => p.Term, "TERM");

            Map(p => p.PriAcadPlanType, "PRI_ACAD_PLAN_TYPE");
            Map(p => p.PriAcadPlan, "PRI_ACAD_PLAN");
            Map(p => p.PriAcadPlanLdesc, "PRI_ACAD_PLAN_LDESC");
            Map(p => p.PriAcadDegree, "PRI_ACAD_DEGREE");
            Map(p => p.PriAcadCollege, "PRI_ACAD_COLLEGE");

            Map(p => p.SecAcadPlanType, "SEC_ACAD_PLAN_TYPE");
            Map(p => p.SecAcadPlan, "SEC_ACAD_PLAN");
            Map(p => p.SecAcadPlanLdesc, "SEC_ACAD_PLAN_LDESC");
            Map(p => p.SecAcadDegree, "SEC_ACAD_DEGREE");
            Map(p => p.SecAcadCollege, "SEC_ACAD_COLLEGE");

            Map(p => p.TerAcadPlanType, "TER_ACAD_PLAN_TYPE");
            Map(p => p.TerAcadPlan, "TER_ACAD_PLAN");
            Map(p => p.TerAcadPlanLdesc, "TER_ACAD_PLAN_LDESC");
            Map(p => p.TerAcadDegree, "TER_ACAD_DEGREE");
            Map(p => p.TerAcadCollege, "TER_ACAD_COLLEGE");

            Map(p => p.QuaAcadPlanType, "QUA_ACAD_PLAN_TYPE");
            Map(p => p.QuaAcadPlan, "QUA_ACAD_PLAN");
            Map(p => p.QuaAcadPlanLdesc, "QUA_ACAD_PLAN_LDESC");
            Map(p => p.QuaAcadDegree, "QUA_ACAD_DEGREE");
            Map(p => p.QuaAcadCollege, "QUA_ACAD_COLLEGE");

            Table("ACAD_PLAN_FULL_VIEW");
            SchemaAction.None();
        }
    }
}
