using FluentNHibernate.Mapping;
using NHibernate.Mapping.ByCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Commencement_Mvc_Data.DTO.Mappings{
    class SnippetMap  : ClassMap<Snippet> {
        public SnippetMap() {
            Id(x => x.Id, "ID");
            Map(p => p.Effdt, "EFFDT");
            Map(p => p.MvcView, "MVC_VIEW");
            Map(p => p.SnippetName, "SNIPPET_NAME");
            Map(p => p.SnippetHtml, "SNIPPET_HTML");
            Table("HTML_SNIPPETS");
        }
    }
}
