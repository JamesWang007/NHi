using FluentNHibernate.Mapping;
using NHibernate.Mapping.ByCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Commencement_Mvc_Data.DTO.Mappings{
    class StudentSaveMap  : ClassMap<StudentSave> {

        public StudentSaveMap() {
            CompositeId(x => x.Id)
                .KeyProperty(x => x.Emplid, "EMPLID")
                .KeyProperty(x => x.CommencementTerm, "COMMENCEMENT_TERM")
                .KeyProperty(x => x.CeremonyAcadPlan, "CEREMONY_ACAD_PLAN");
            Map(p => p.PriAcadPlan, "PRI_ACAD_PLAN");
            Map(p => p.PriAcadDegree, "PRI_ACAD_DEGREE");
            Map(p => p.SecAcadPlan, "SEC_ACAD_PLAN");
            Map(p => p.SecAcadDegree, "SEC_ACAD_DEGREE");
            Map(p => p.ParticipatePriAcadPlan, "PARTICIPATE_PRI_ACAD_PLAN");    // Always '9' in latest term
            Map(p => p.ParticipateSecAcadPlan, "PARTICIPATE_SEC_ACAD_PLAN");    // Always '9' in latest term
            Map(p => p.StatusAfterGrad, "STATUS_AFTER_GRAD");                   // Always null in latest term
            Map(p => p.Organization, "ORGANIZATION");                           // Always null in latest term
            Map(p => p.JobTitle, "JOBTITLE");                                   // Always null in latest term
            Map(p => p.CellPhoneNbr, "CELL_PHONE_NBR");

            Table("TEST_ALM_COMMENCEMENT");     //TODO: Change before deployment
            SchemaAction.None();
        }
    }
}