using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Commencement_Mvc_Data.Repositories;

namespace Commencement_Mvc_Data.DTO
{
    public class CommencementTerm
    {
        // Mapped
        public virtual string Term { get; set; }
        public virtual string CommencementTermLdesc { get; set; }
        public virtual DateTime BeginDt { get; set; }
        public virtual DateTime EndDt { get; set; }
    }
}