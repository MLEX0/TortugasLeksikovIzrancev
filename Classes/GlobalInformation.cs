using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TartugaLeksikovIzrancev.Classes;

namespace TartugaLeksikovIzrancev.Classes
{
    //Класс с различной глобальной информацией
    public static class GlobalInformation
    {
        public static EF.RestourantTable IDTable { get; set; }

        public static List<EF.Product> ListOfOrder = new List<EF.Product>();
        public static EF.Promocode Promocode { get; set; } = new EF.Promocode();
     
    }
}
