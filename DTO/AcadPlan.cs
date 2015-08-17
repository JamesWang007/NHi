using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Commencement_Mvc_Data.DTO
{
    public class AcadPlan
    {
        public virtual string Id { get; set; }
        [RegularExpression("[0-9]*")]
        public virtual string Emplid { get; set; }
        public virtual int Term { get; set; }

        public virtual string PriAcadPlanType { get; set; }
        public virtual string PriAcadPlan { get; set; }
        public virtual string PriAcadPlanLdesc { get; set; }
        public virtual string PriAcadDegree { get; set; }
        public virtual string PriAcadCollege { get; set; }

        public virtual string SecAcadPlanType { get; set; }
        public virtual string SecAcadPlan { get; set; }
        public virtual string SecAcadPlanLdesc { get; set; }
        public virtual string SecAcadDegree { get; set; }
        public virtual string SecAcadCollege { get; set; }

        public virtual string TerAcadPlanType { get; set; }
        public virtual string TerAcadPlan { get; set; }
        public virtual string TerAcadPlanLdesc { get; set; }
        public virtual string TerAcadDegree { get; set; }
        public virtual string TerAcadCollege { get; set; }

        public virtual string QuaAcadPlanType { get; set; }
        public virtual string QuaAcadPlan { get; set; }
        public virtual string QuaAcadPlanLdesc { get; set; }
        public virtual string QuaAcadDegree { get; set; }
        public virtual string QuaAcadCollege { get; set; }

        //  Unmapped
        private List<Major> majors;
        public virtual List<Major> Majors
        {
            get
            {
                if (majors == null)
                {
                    majors = new List<Major>();
                    if (PriAcadPlanType == "MAJ")
                    {
                        majors.Add(new Major(PriAcadPlanType, PriAcadPlan, PriAcadPlanLdesc, PriAcadDegree, PriAcadCollege));
                    }
                    if (SecAcadPlanType == "MAJ")
                    {
                        majors.Add(new Major(SecAcadPlanType, SecAcadPlan, SecAcadPlanLdesc, SecAcadDegree, SecAcadCollege));
                    }
                    if (TerAcadPlanType == "MAJ")
                    {
                        majors.Add(new Major(TerAcadPlanType, TerAcadPlan, TerAcadPlanLdesc, TerAcadDegree, TerAcadCollege));
                    }
                    if (QuaAcadPlanType == "MAJ")
                    {
                        majors.Add(new Major(QuaAcadPlanType, QuaAcadPlan, QuaAcadPlanLdesc, QuaAcadDegree, QuaAcadCollege));
                    }
                }
                return majors;
            }
        }
    }
}