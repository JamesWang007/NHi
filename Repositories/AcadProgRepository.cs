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
    public class AcadProgRepository : Repository<AcadProg>
    {
        public List<AcadProg> GetAllByEmplid(string emplid)
        {
            return (
                from p in this.Set
                where p.Emplid == emplid
                select p
                ).ToList();
        }

        public AcadProg GetLatestByEmplid(string emplid)
        {
            return (
                from p in this.Set
                where p.Emplid == emplid
                orderby p.Effdt descending, p.Effseq descending, p.StdntCarNbr descending
                select p
                ).First();
        }

        // If a student has a value returned from this query, they are eligible to register for commencement
        public AcadProg GetLatestEligible(string emplid, string term)
        {
            string[] termArray = GetTermArray(term);
            if (termArray == null)
            {
                return null;
            }

            return (
                from p in this.Set
                where p.Emplid == emplid 
                where (
                        (p.AcadCareer == "UGRD" && p.Prog == "UGRD") || 
                        (p.AcadCareer == "PBAC" && p.Prog == "PBAC") ||
                        (p.AcadCareer == "UGRD" && p.Prog == "UGCE") ||
                        (p.AcadCareer == "PBAC" && p.Prog == "PBCE")
                      )
                where (
                        (p.ProgAction == "RADM" && p.ProgReason == "GO") ||
                        (p.ProgAction == "COMP") ||
                        (p.ProgAction == "DATA" && (
                                                    p.ProgReason == "EG" ||
                                                    p.ProgReason == "EGRF" ||
                                                    p.ProgReason == "EGNR" ||
                                                    p.ProgReason == "EGRV"
                                                    )
                        )
                      )
                where (
		            (p.ExpGradTerm == termArray[0]) ||
		            (p.ExpGradTerm == termArray[1]) ||
		            (p.ExpGradTerm == termArray[2]) ||
		            (p.ExpGradTerm == termArray[3]) ||
		            (p.ExpGradTerm == termArray[4])
	            )
                orderby p.Effdt descending, p.Effseq descending, p.StdntCarNbr descending
                select p
            ).FirstOrDefault();
        }

        public string[] GetTermArray(string term)
        {
            int termInt;
            if (!int.TryParse(term, out termInt))
            {
                return null;
            }
            List<int> termIntList = new List<int>();
            termIntList.Add(termInt - 6);
            termIntList.Add(termInt - 4);
            termIntList.Add(termInt);
            termIntList.Add(termInt + 4);
            termIntList.Add(termInt + 6);

            string[] termArray = termIntList.ConvertAll<string>(x => x.ToString()).ToArray();

            return termArray;
        }

        public int Parse(string s)
        {
            int i = -1;
            int.TryParse(s, out i);
            return i;
        }

    }
}