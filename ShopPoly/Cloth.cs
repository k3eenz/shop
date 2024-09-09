using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopPoly
{
    public class Cloth : Product
    {
        public string Type { get; set; }
        public int Size { get; set; }
        public override string GetInformation()
        {
            return $"Информация о одежде:\n" +
                $"Тип: {Type}\n" +
                $"Размер: {Size}\n" +
                $"Стоимость: {Price} руб.\n";
        }
        protected override decimal GetDiscount()
        {
            return 0.2m;
        }
    }
}
