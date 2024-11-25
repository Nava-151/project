using rentDresses.Entities;

namespace rentDresses
{
    public class TestContextDress : IdataContext
    {
        public List<Dress> Load()
        {
            List<Dress> data = new List<Dress>();
            data.Add(new Dress() { Amount=18, Color="red", FabricType="cotton", Id=1, Seazons=Seazon.Fall, Size=18, YearOfManufacture=new DateTime(2020,10,5)});
            data.Add(new Dress() { Amount=17, Color="red", FabricType="cotton", Id=2, Seazons=Seazon.Fall, Size=18, YearOfManufacture=new DateTime(2020,10,5)});
            return data;
        }

        public bool Save(List<Dress> dressList)
        {
            return true;
        } 
    }
}
