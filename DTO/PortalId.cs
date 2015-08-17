using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Commencement_Mvc_Data.DTO
{
    public class PortalId
    {
        public virtual string Emplid { get; set; }
        public virtual string UserId { get; set; }
        public virtual string Initialized { get; set; }
        public virtual string CepId { get; set; }
    }
}