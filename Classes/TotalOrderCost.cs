using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TartugaLeksikovIzrancev.Classes
{
    public class TotalOrderCost
    {
        public static string totalPrice(List<EF.Product> products)
        {
            decimal totalCost = 0;
            foreach (EF.Product prod in products)
            {
                totalCost += prod.Cost;
            }

            // акция "Белая суббота".
            if ((DateTime.Now.Day == 29 || DateTime.Now.Day == 30 || DateTime.Now.Day == 31) && DateTime.Now.DayOfWeek.ToString() == "Saturday")
            {
                totalCost = totalCost - (totalCost * Convert.ToDecimal(0.11));              
            }
            else
            {
                totalCost = totalCost - (totalCost * Convert.ToDecimal(GlobalInformation.Promocode.Discount));            
            }
            return Convert.ToString(totalCost);
        }
    }
}
