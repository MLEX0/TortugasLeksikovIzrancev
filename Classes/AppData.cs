using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TartugaLeksikovIzrancev.EF;

namespace TartugaLeksikovIzrancev.Classes
{
    //Класс для работы с базой данных
    class AppData
    {
        public static Entities Context { get; } = new Entities();
    }
}
