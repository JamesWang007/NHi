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
    public class AddressRepository : Repository<Address>
    {
        public Address GetByEmplid(string emplid)
        {
            return (
                from p in this.Set
                where p.Emplid == emplid
                select p
                ).FirstOrDefault();
        }
    }
}