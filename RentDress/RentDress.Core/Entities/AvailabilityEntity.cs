using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RentDress.Core.Entities
{
    [Table("Availability")]
    public class AvailabilityEntity
    {
        //זמינות לפי קוד שמלה
        [Key]
        public int Id { get; set; }

        //שדה חיפוש
        public int DressCode { get; set; }
        public int RentCode { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public int AmountTaken { get; set; }

        public AvailabilityEntity()
        {

        }
        public AvailabilityEntity(int id, int dressCode, int rentCode, DateTime from, DateTime to, int amountTaken)
        {
            Id = id;
            DressCode = dressCode;
            RentCode = rentCode;
            From = from;
            To = to;
            AmountTaken = amountTaken;
        }
    }
}
