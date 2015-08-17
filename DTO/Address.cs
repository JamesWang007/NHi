using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Commencement_Mvc_Data.DTO
{
    public class Address
    {
        // Mapped
        public virtual string Id { get; set; }
        public virtual string Emplid { get; set; }
        public virtual string Address1 { get; set; }
        public virtual string Address2 { get; set; }
        public virtual string City { get; set; }
        public virtual string State { get; set; }
        public virtual string PostalZip { get; set; }
        public virtual string Phone { get; set; }
        public virtual string EmailAddress { get; set; }
        //Unmapped
        public virtual string FullAddress
        {
            get
            {
                string fullAddress = (Address1 + " ");
                if (!string.IsNullOrWhiteSpace(Address2))
                {
                    fullAddress += (Address2 + " ");
                }
                fullAddress += (City + ", ");
                fullAddress += (State + " ");
                fullAddress += (PostalZip + " ");
                return fullAddress;
            }
        }
    }
}