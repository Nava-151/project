using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace RentDress.Core.Entities
{
    public class UserEntity
    {
        public string Tz { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Addres { get; set; }
        public int ZipCode { get; set; }
        public string TellNum { get; set; }

    }
}
