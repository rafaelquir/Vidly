﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        [Display(Name = "Nombre")]
        public string Name { get; set; }
        [Display(Name = "Yo estoy suscrito")]
        public bool IsSubscribedToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; }
        [Display(Name = "Tipo de membresia")]
        public byte MembershipTypeId { get; set; }
        [Display(Name = "Día de Nacimiento")]
        [Min18YearsIfAMember]
        public DateTime? BirthDate { get; set; }
    }
}