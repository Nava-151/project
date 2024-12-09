using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace RentDress.Core.Entities
{
    [Table("User")]
    public class UserEntity
    {
        //שדה חיפוש
        [Required, MaxLength(9)]
        public string Tz { get; set; }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Addres { get; set; }
        public int ZipCode { get; set; }

        [MaxLength(10)]
        public string TellNum { get; set; }
        public UserEntity()
        {

        }

        public UserEntity(string tz, int id, string name, string email, string addres, int zipCode, string tellNum)
        {
            Tz = tz;
            Id = id;
            Name = name;
            Email = email;
            Addres = addres;
            ZipCode = zipCode;
            TellNum = tellNum;
        }
    }
}
