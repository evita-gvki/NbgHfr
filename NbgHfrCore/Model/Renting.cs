using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbgHfrCore.Model
{
    public class Renting
    {
        public int RentingId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }

        public virtual Property Propery { get; set; }
        public virtual User User { get; set; }
    }
}
