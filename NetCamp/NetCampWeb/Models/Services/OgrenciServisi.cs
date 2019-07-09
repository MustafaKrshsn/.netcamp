using NetCampWeb.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCampWeb.Models.Services
{
    public class OgrenciServisi
    {
        public OgrenciServisi()
        {
            if(GlobalData.Ogrenciler==null)
            {
                GlobalData.Ogrenciler = new List<Ogrenci>();
            }

        }

        public List<Ogrenci> GetList()
        {
            return GlobalData.Ogrenciler;
        }
    }
}
