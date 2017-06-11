using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Powerco.Models
{
    public class CustomerJoin
    {
        
        [Required(ErrorMessage ="First Name Required")]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name Required")]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Postal Code Required")]
        [DisplayName("Postal Code")]
        public string PostCode { get; set; }

        [Required(ErrorMessage = "Account Number Required")]
        [DisplayName("Existing Account Number")]
        public string AccountNumber { get; set; }
        
        [Required(ErrorMessage = "Salutation Required")]
        public string Salutation { get; set; }
               
        [DisplayName("Identity Card")]
        public string IdentityCard { get; set; }

        [DisplayName(" ")]
        public string IdentityNumber { get; set; }

        [DisplayName("Block/House No")]
        public string BlockHouseNo { get; set; }

        [DisplayName("Floor No")]
        public string FloorNo { get; set; }
        
        [DisplayName("Unit No")]
        public string UnitNo { get; set; }

        [DisplayName("Street Name")]
        public string StreetName { get; set; }

        [Required(ErrorMessage = "Mobile Number Required")]
        [DisplayName("Mobile Number")]
        public string MobileNumber { get; set; }
        
        [Required(ErrorMessage = "Email Address Required")]
        [DisplayName("Email Address")]
        public string EmailAddress { get; set; }

        public List<string> IdentityCardTypes { get; set; }

        public List<string> Salutations { get; set; }

        public CustomerJoin()
        {
            Salutations = new List<string>
                {
                    "Mr",
                    "Ms",
                    "Mrs",
                    "Mdm",
                    "Dr"
                };

            IdentityCardTypes = new List<string>
                {
                    "NRIC",
                    "FIN"
                };
        }

    }

}