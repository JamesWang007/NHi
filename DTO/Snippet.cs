using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Commencement_Mvc_Data.DTO
{
    public class Snippet
    {
        public virtual int Id { get; set; }
        public virtual DateTime Effdt { get; set; }
        public virtual string MvcView { get; set; }
        public virtual string SnippetName { get; set; }
        public virtual string SnippetHtml { get; set; }
    }
}