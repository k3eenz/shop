using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopPoly
{
    public class Drinks : Product
    {
        public bool isAlcohol { get; set; }
        public override string GetInformation()
        {
            return $"Информация о напитке:\n" +
                   $"Название: {Name}\n" +
                   $"Тип: {(isAlcohol ? "Алкогольный" : "Безалкогольный")}\n" +
                   $"Стоимость: {Price} руб.\n";
        }
        protected override decimal GetDiscount()
        {
            return 0.3m;
        }
    }
}
