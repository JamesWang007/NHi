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
    public class StudentSaveRepository : Repository<StudentSave>
    {
        public StudentSave GetByEmplidAndTerm(string emplid, string term)
        {
            return (
                from p in this.Set
                where p.Id.Emplid == emplid
                where p.Id.CommencementTerm == term
                select p
                ).FirstOrDefault();
        }

        public StudentSave GetByEmplidTermAndAcadPlan(string emplid, string term, string acadPlan)
        {
            return (
                from p in this.Set
                where p.Id.Emplid == emplid
                where p.Id.CommencementTerm == term
                where p.Id.CeremonyAcadPlan == acadPlan
                select p
                ).FirstOrDefault();
        }

        public List<StudentSave> GetAllByEmplidAndTerm(string emplid, string term)
        {
            return (
                from p in this.Set
                where p.Id.Emplid == emplid
                where p.Id.CommencementTerm == term
                select p
                ).ToList();
        }
    }
}