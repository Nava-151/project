using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RentDress.Core.Entities
{
    public class AvailabilityEntity
    {
        public int Id { get; set; }
        public int DressCode { get; set; }
        public int RentCOde { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }

        public int AmountTaken { get; set; }
    }
}
