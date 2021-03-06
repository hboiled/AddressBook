﻿using AddressBookDataAccess.Models.Contact;
using AddressBookMVC.Models.Contact;
using Microsoft.AspNetCore.Hosting.Server.Features;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBookMVC.Models.ViewModels
{
    public class PersonSubmitViewModel
    {
        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("Email Addresses")]
        public List<EmailViewModel> EmailAddresses { get; set; } = new List<EmailViewModel>();
        [DisplayName("Phone Number")]
        public List<PhoneNumViewModel> PhoneNumbers { get; set; } = new List<PhoneNumViewModel>();
        [DisplayName("Address")]
        public List<AddressViewModel> Addresses { get; set; } = new List<AddressViewModel>();
    }
}