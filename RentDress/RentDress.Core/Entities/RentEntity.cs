using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace RentDress.Core.Entities
{
    public enum Pay { credit, cash, check }

    [Table("Rent")]
    public class RentEntity
    {
        [Key]
        public int Id { get; set; }
        public int RentCode { get; set; }
        public DateTime CollectionDate { get; set; }
        public DateTime ReturnDate { get; set; }

        [Column(TypeName = "decimal(18,3)")]
        public decimal TotalPrice { get; set; }
        public DateTime CreateDate { get; set; }
        public string Name { get; set; }
        public Pay Payment { get; set; }
        public RentEntity()
        {

        }

        public RentEntity(int id, int rentCode, DateTime collectionDate, DateTime returnDate, decimal totalPrice, DateTime createDate, string name, Pay payment)
        {
            Id = id;
            RentCode = rentCode;
            CollectionDate = collectionDate;
            ReturnDate = returnDate;
            TotalPrice = totalPrice;
            CreateDate = createDate;
            Name = name;
            Payment = payment;
        }
    }
}
