using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Commencement_Mvc_Data.DTO
{
    public class AcadProg
    {
        public virtual string Id { get; set; }
        public virtual string Emplid { get; set; }
        public virtual string ExpGradTerm { get; set; }
        public virtual DateTime Effdt { get; set; }
        public virtual int Effseq { get; set; }
        public virtual int StdntCarNbr { get; set; }
        public virtual string Prog { get; set; }
        public virtual string AcadCareer { get; set; }
        public virtual string ProgAction { get; set; }
        public virtual string ProgReason { get; set; }
    }
}