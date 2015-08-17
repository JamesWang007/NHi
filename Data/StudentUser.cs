using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Commencement_Mvc_Data.DTO;
using Commencement_Mvc_Data.Repositories;

namespace Commencement_Mvc_Data.DTO
{
    public class StudentUser
    {
        public StudentUser(string id)
        {
            if (IsDigitsOnly(id))
            {
                using (PortalIdRepository pdb = new PortalIdRepository())
                {
                    PortalId = pdb.GetByEmplid(AddLeadingZeros(id));
                }
            }
            else 
            {
                using (PortalIdRepository pdb = new PortalIdRepository())
                {
                    PortalId = pdb.GetByUserId(id);
                }
            }
            if (PortalId == null)   // Couldn't find student
            {
                PortalId = new PortalId();
                acadPlan = new AcadPlan();
                address = new Address();
                name = new Name();
                acadProg = new AcadProg();
            }
        }

        public StudentUser()
        {
        }

        public PortalId PortalId { get; set; }

        public string CellPhone { get; set; }

        private AcadPlan acadPlan;
        public AcadPlan AcadPlan
        {
            get
            {
                if (acadPlan == null)
                {
                    using (AcadPlanRepository adb = new AcadPlanRepository())
                    {
                        acadPlan = adb.GetLatestByEmplid(PortalId.Emplid);
                    }
                }
                return acadPlan ?? new AcadPlan();
            }
        }

        private Address address;
        public Address Address
        {
            get
            {
                if (address == null)
                {
                    using (AddressRepository adb = new AddressRepository())
                    {
                        address = adb.GetByEmplid(PortalId.Emplid);
                    }
                }
                return address ?? new Address();
            }
        }

        private Name name;
        public Name Name
        {
            get
            {
                if (name == null)
                {
                    using (NameRepository ndb = new NameRepository())
                    {
                        name = ndb.GetByEmplid(PortalId.Emplid);
                    }
                }
                return name ?? new Name();
            }
        }

        private AcadProg acadProg;
        public AcadProg AcadProg
        {
            get
            {
                if (acadProg == null)
                {
                    using (AcadProgRepository adb = new AcadProgRepository())
                    {
                        acadProg = adb.GetLatestByEmplid(PortalId.Emplid);
                    }
                }
                return acadProg ?? new AcadProg();
            }
        }

        public string ChosenMajor { get; set; }

        bool IsDigitsOnly(string str)
        {
          foreach (char c in str)
          {
            if (c < '0' || c > '9')
              return false;
          }

          return true;
        }
        
        public static string AddLeadingZeros(string emplid)
        {
            while (emplid.Length < 9)
            {
                emplid = "0" + emplid;
            }
            return emplid;
        }
    }
}