using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopPoly
{
    public class Toy : Product
    {
        public string Material { get; set; }
        public override string GetInformation()
        {
            return $"Информация о игрушке:\n" +
                $"Название: {Name}\n" +
                $"Материал: {Material}\n" +
                $"Стоимость: {Price} руб.\n";
        }
        protected override decimal GetDiscount()
        {
            return 0.2m;
        }
    }
}
