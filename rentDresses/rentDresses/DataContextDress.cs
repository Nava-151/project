using rentDresses.Entities;
using System.Text.Json;

namespace rentDresses
{
    public class DataContextDress : IdataContext
    {
        //
         List<Dress> IdataContext.Load()
        {
            try
            {
                string path = Path.Combine(AppContext.BaseDirectory, "Data", "data.json");
                string jsonString = File.ReadAllText(path);
                var dList = JsonSerializer.Deserialize<List<Dress>>(jsonString);// typeof(DataCoins)); ;
                if (dList == null) { return null; }
                return dList;
            }
            catch
            {
                return null;
            }
        }

         bool IdataContext.Save(List<Dress> data)
        {
            try
            {
                //
                DataDress d=new DataDress();
                d.db = data;
                //
                string path = Path.Combine(AppContext.BaseDirectory, "Data", "data.json");
                string jsonString = JsonSerializer.Serialize<List<Dress>>(data);
                File.WriteAllText(path, jsonString);
                return true;
            }
            catch { return false; }
        }
    }
}
