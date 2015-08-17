using NHibernate;
using NHibernate.Criterion;
using NHibernate.Linq;
using Commencement_Mvc_Data;
using Commencement_Mvc_Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commencement_Mvc_Data.Repositories
{
    public class SnippetRepository : Repository<Snippet>
    {
        public Snippet GetLatestByViewAndName(string view, string name)
        {
            return (
                from p in this.Set
                where p.MvcView == view
                where p.SnippetName == name
                orderby p.Effdt descending
                select p
                ).FirstOrDefault();
        }

        public List<Snippet> GetLatestByView(string view)
        {
            return (
                from p in this.Set
                where p.MvcView == view
                where p.Effdt == (from p2 in this.Set
                                  where p2.MvcView == p.MvcView
                                  where p2.SnippetName == p.SnippetName
                                  select p2.Effdt).Max()
                orderby p.SnippetName
                select p
                ).ToList();
        }

        public List<Snippet> GetAllLatest()
        {
            return (
                from p in this.Set
                where p.Effdt == (from p2 in this.Set
                                  where p2.MvcView == p.MvcView
                                  where p2.SnippetName == p.SnippetName
                                  select p2.Effdt).Max()
                orderby p.SnippetName
                select p
                ).ToList();
        }

        public List<Snippet> GetAllByViewAndName(string view, string name)
        {
            return (
                from p in this.Set
                where p.MvcView == view
                where p.SnippetName == name
                orderby p.Effdt descending
                select p
                ).ToList();
        }
    }
}