using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace RentDress.Core.Entities
{
    public enum Pay { credit, cash, check }
    public class RentEntity
    {
        //link to customers
        public int Id { get; set; }
        public DateTime CollectionDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime CreateDate { get; set; }
        public string Name { get; set; }
        public Pay Payment { get; set; }

    }
}
