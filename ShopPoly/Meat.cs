using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopPoly
{
    public class Meat : Product
    {
        public string Type { get; set; }
        public override string GetInformation()
        {
            return $"Информация о мясе:\n" +
                $"Тип: {Type}\n" +
                $"Стоимость: {Price} руб.\n";
        }
    }
}
