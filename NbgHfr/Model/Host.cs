using System;
using System.Collections.Generic;
using System.Text;

namespace NbgHfrCore.Model
{
    public class Host
    {
        public int HostId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }     
        public string Email { get; set; }
        public string PhoneNumber{ get; set; }
        public string Address { get; set; }

        public virtual List<Property> Properties { get; set; }
    }
}
