using rentDresses.Entities;

namespace rentDresses
{
    public interface IdataContext
    {
        public  List<Dress> Load();
        public  bool Save(List<Dress> dressList);

    }
}
