using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Commencement_Mvc_Data.DTO
{
    public class Major
    {
        public Major (string acad_plan_type, string acad_plan, string acad_plan_ldesc, string acad_degree, string acad_college)
        {
            AcadPlanType = acad_plan_type;
            AcadPlan = acad_plan;
            AcadPlanLdesc = acad_plan_ldesc;
            AcadDegree = acad_degree;
            AcadCollege = acad_college;
        }

        public Major() { }

        public virtual string AcadPlanType { get; set; }
        public virtual string AcadPlan { get; set; }
        public virtual string AcadPlanLdesc { get; set; }
        public virtual string AcadDegree { get; set; }
        public virtual string AcadCollege { get; set; }
        public virtual string AcadCeremony { get; set; }
    }
}