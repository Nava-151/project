using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentDress.Core.Entities
{
    public enum Seazon { Winter, Fall, Spring, Summer }

    [Table("Dress")]
    public class DressEntity
    {
        [Key]
        public int Id { get; set; }
        //שדה חיפוש
        public int DressCode { get; set; }
        public int Size { get; set; }
        public string Color { get; set; }

        public Seazon Seazons { get; set; }
        public int Amount { get; set; }
        public string FabricType { get; set; }
        public DateTime YearOfManufacture { get; set; }
        public DressEntity()
        {

        }

        public DressEntity(int id, int dressCode, int size, string color, Seazon seazons, int amount, string fabricType, DateTime yearOfManufacture)
        {
            Id = id;
            DressCode = dressCode;
            Size = size;
            Color = color;
            Seazons = seazons;
            Amount = amount;
            FabricType = fabricType;
            YearOfManufacture = yearOfManufacture;
        }
    }
}
