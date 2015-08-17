using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Commencement_Mvc_Data.DTO
{
    public class CommencementCeremony
    {
        public virtual string College { get; set; }
        public virtual int Ceremony { get; set; }
        public virtual int MaxTicketsAllowed { get; set; }
    }
}