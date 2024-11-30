using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace RentDress.Core.Entities
{
    public class RentDetailsEntity
    {
        public int Id { get; set; }
        public int DressCode { get; set; }
        public int RentCode { get; set; }
        public int UserCode { get; set; }
    }
}
