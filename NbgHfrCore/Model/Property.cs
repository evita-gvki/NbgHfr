using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbgHfrCore.Model
{
    public class Property
    {
        public int PropertyId { get; set; }
        public decimal Price { get; set; }
        public String Location { get; set; }
        public Description Description { get; set; }
        public bool Availability { get; set; }

        public virtual Host Host { get; set; }
        public virtual List<Renting> Rentings { get; set; }

    }
}
