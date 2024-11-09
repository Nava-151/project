using Microsoft.AspNetCore.Mvc;
using rentDresses.Entities;

namespace rentDresses
{
    public class Validation<T>
    {
        public Validation() { }
        public ActionResult<bool> CheckValidTz(User u)
        {
            if (u.Tz.Length < 9)
                return true;
            int[] id_12_digits = { 1, 2, 1, 2, 1, 2, 1, 2, 1 };
            int count = 0;

            if (u.Tz == null)
                return false;
            u.Tz = u.Tz.PadLeft(9, '0');

            for (int i = 0; i < 9; i++)
            {
                int num = Int32.Parse(u.Tz.Substring(i, 1)) * id_12_digits[i];

                if (num > 9)
                    num = (num / 10) + (num % 10);

                count += num;
            }

            return (count % 10 == 0);
        }
        public bool LenTz(string tz)
        {
            if (tz.Length < 9)
                return false;
            return true;
        }
        

    }
}
