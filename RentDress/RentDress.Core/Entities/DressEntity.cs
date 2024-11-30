using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentDress.Core.Entities
{
    public enum Seazon { Winter, Fall, Spring, Summer }

    public class DressEntity
    {
            public int Id { get; set; }
            public int Size { get; set; }
            public string Color { get; set; }

            public Seazon Seazons { get; set; }
            public int Amount { get; set; }
            public string FabricType { get; set; }
            public DateTime YearOfManufacture { get; set; }
            public DressEntity()
            {

            }
            public DressEntity(int id, int size, string color, Seazon seazons, int amount, string fabricType, DateTime yearOfManufacture)
            {
                Id = id;
                Size = size;
                Color = color;
                Seazons = seazons;
                Amount = amount;
                FabricType = fabricType;
                YearOfManufacture = yearOfManufacture;
            }
       
    }
}
