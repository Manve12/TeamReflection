using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeamReflection.Models
{
    public class AccountModel
    {
        public string Username { get; set; }
        public string Fullname { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string BillingFirstLine { get; set; }
        public string BillingPostCode { get; set; }
        public string BillingCounty { get; set; }
    }
}