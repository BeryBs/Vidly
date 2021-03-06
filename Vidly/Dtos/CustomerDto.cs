using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }
        [Required] //Data Annotion
        [StringLength(255)] //Max number of character that string can have
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
     
        public byte MembershipTypeId { get; set; } //foreign key
        public MembershipTypeDto MembershipType { get; set; }
        public DateTime? Birthdate { get; set; }
    }
}