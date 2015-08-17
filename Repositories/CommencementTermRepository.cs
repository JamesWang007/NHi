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
    public class CommencementTermRepository : Repository<CommencementTerm>
    {
        public List<CommencementTerm> GetAll()
        {
            return this.Set.ToList();
        }

        public CommencementTerm GetLatest()
        {
            return (
            from p in this.Set
            orderby p.Term descending
            select p
            ).First();        
        }

        public CommencementTerm GetActive() {
            return (
            from p in this.Set
            where p.BeginDt < System.DateTime.Now && p.EndDt > System.DateTime.Now
            orderby p.Term descending
            select p
            ).FirstOrDefault();
        }

        public CommencementTerm GetActiveByTerm(string term) {
            return (
            from p in this.Set
            where p.Term == term
            where p.BeginDt < System.DateTime.Now && p.EndDt > System.DateTime.Now
            select p
            ).FirstOrDefault();
        }

    }
}