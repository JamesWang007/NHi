using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Commencement_Mvc_Data.DTO
{
    public class Name
    {
        // Mapped
        public virtual string Id { get; set; }
        public virtual string Emplid { get; set; }
        public virtual string LastName { get; set; }
        public virtual string FirstName { get; set; }
        //Unmapped
        public virtual string FullName
        {
            get
            {
                return (FirstName + " " + LastName);
            }
        }
    }
}