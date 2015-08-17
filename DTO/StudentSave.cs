using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Commencement_Mvc_Data.DTO
{
    public class StudentSave
    {
        public virtual StudentSaveId Id { get; set; }
        public virtual string PriAcadPlan { get; set; }
        public virtual string PriAcadDegree { get; set; }
        public virtual string SecAcadPlan { get; set; }
        public virtual string SecAcadDegree { get; set; }
        public virtual int ParticipatePriAcadPlan { get; set; }
        public virtual int ParticipateSecAcadPlan { get; set; }
        public virtual string StatusAfterGrad { get; set; }
        public virtual string Organization { get; set; }
        public virtual string JobTitle { get; set; }
        public virtual string CellPhoneNbr { get; set; }
    }

    public class StudentSaveId
    {
        public string Emplid { get; set; }
        public string CommencementTerm { get; set; }
        public string CeremonyAcadPlan { get; set; }

        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }

            var studentSave = obj as StudentSaveId;

            if(studentSave == null)
            {
                return false;
            }

            if(Emplid == studentSave.Emplid && CommencementTerm == studentSave.CommencementTerm && CeremonyAcadPlan == studentSave.CeremonyAcadPlan)
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return (Emplid + CommencementTerm).GetHashCode();
        }
    }
}
