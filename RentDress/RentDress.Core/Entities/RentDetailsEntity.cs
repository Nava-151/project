using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace RentDress.Core.Entities
{
    [Table("RentDetails")]
    public class RentDetailsEntity
    {
        [Key]
        public int Id { get; set; }
        public int DressCode { get; set; }
        //שדה חיפוש
        public int RentCode { get; set; }
        public int UserCode { get; set; }
        public RentDetailsEntity()
        {
            
        }

        public RentDetailsEntity(int id, int dressCode, int rentCode, int userCode)
        {
            Id = id;
            DressCode = dressCode;
            RentCode = rentCode;
            UserCode = userCode;
        }
    }
}
