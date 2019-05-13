using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneUro.Depo
{
    class Numaralar
    {
        public string HastaNo()
        {
            UrologyDataContext _db = new UrologyDataContext();
            try
            {
                int numara = ((from s in _db.HastaBilgis
                               orderby s.ID descending
                               select s).First()).HastaNo.Value;
                numara++;
                string num = numara.ToString().PadLeft(7, '0');
                return num;
            }
            catch (Exception)
            {
                return "0000001";
            }
        }
    }
}
