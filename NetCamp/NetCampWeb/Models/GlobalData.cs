using NetCampWeb.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCampWeb.Models.Services
{
    //Sınıf static ise metod da static olmalı

    public static class GlobalData
    {

        public static List<Ogrenci> Ogrenciler { get; set; } 


    }
}
