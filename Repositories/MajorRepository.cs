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
    public class MajorRepository : Repository<Major>
    {
        public Major GetByAcadPlan(string acadPlan)
        {
            return (
                from p in this.Set
                where p.AcadPlan == acadPlan
                select p
                ).FirstOrDefault();
        }
    }
}