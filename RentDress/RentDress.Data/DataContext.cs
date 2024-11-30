using RentDress.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RentDress.Data
{
    public class DataContext
    {
        public List<DressEntity> DressList { get; set; }
        public List<UserEntity> UserList { get; set; }
        public List<RentEntity> RentList { get; set; }
        public List<AvailabilityEntity> AvailabilityList { get; set; }
        public List<RentDetailsEntity> RentDetailsList { get; set; }

        public DataContext()
        {
            string path = Path.Combine(AppContext.BaseDirectory, "Datas", "data.json");
            string jsonString = File.ReadAllText(path);
            DressList = JsonSerializer.Deserialize<List<DressEntity>>(jsonString);
        }

        
        public List<DressEntity> LoadData()
        {

            try
            {
                string path = Path.Combine(AppContext.BaseDirectory, "Datas", "data.json");
                string jsonString = File.ReadAllText(path);
                var dressList = JsonSerializer.Deserialize<List<DressEntity>>(jsonString);// typeof(DataCoins)); ;
                if (dressList == null) { return null; }
                return dressList;
            }
            catch
            {
                return null;
            }
        }
        public void SaveData()
        {
            string path = Path.Combine(AppContext.BaseDirectory, "Data", "data.json");
            string jsonString = JsonSerializer.Serialize(DressList);
            File.WriteAllText(path, jsonString);
        }
    }
}
