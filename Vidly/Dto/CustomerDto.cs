using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Dto
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter customer's name")]
        [StringLength(100)]
        public string Name { get; set; }

        //[Min18YearsIfAMember]
        public DateTime? Birthday { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public byte MembershipTypeId { get; set; }
        public MembershipTypeDto MembershipType { get; set; }
    }
}