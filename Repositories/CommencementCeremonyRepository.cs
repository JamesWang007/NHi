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
    public class CommencementCeremonyRepository : Repository<CommencementCeremony>
    {
        public CommencementCeremony GetByCollege(string college)
        {
            return (
                from p in this.Set
                where p.College == college
                select p
                ).FirstOrDefault();
        }
        
        public List<CommencementCeremony> GetAll()
        {
            return (
                from p in this.Set
                select p
                ).ToList();
        }
    }
}