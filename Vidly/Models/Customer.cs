using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        
        [Required] //Data Annotion
        [StringLength(255)] //Max number of character that string can have
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public MembershipType MembershipType{ get; set; }
        [Display (Name="Membership Type")]
        public byte MembershipTypeId { get; set; } //foreign key
        public DateTime? Birthdate { get; set; }
    }
}