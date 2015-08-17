using FluentNHibernate.Mapping;
using NHibernate.Mapping.ByCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Commencement_Mvc_Data.DTO.Mappings{
    class AcadProgMap  : ClassMap<AcadProg> {

        public AcadProgMap() {
            Id(x => x.Id, "UNIQUE_ID");
            Map(p => p.Emplid, "EMPLID");
            Map(p => p.ExpGradTerm, "EXP_GRAD_TERM");
            Map(p => p.Effdt, "EFFDT");
            Map(p => p.Effseq, "EFFSEQ");
            Map(p => p.StdntCarNbr, "STDNT_CAR_NBR");
            Map(p => p.Prog, "ACAD_PROG");
            Map(p => p.AcadCareer, "ACAD_CAREER");
            Map(p => p.ProgAction, "PROG_ACTION");
            Map(p => p.ProgReason, "PROG_REASON");
            Table("ACAD_PROG_VIEW");
            SchemaAction.None();
        }
    }
}
