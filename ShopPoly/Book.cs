using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopPoly
{
    public class Book : Product
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public override string GetInformation()
        {
            return $"Информация о книге:\n" +
                $"Название: {Name}\n" +
                $"Автор: {Author}\n" +
                $"Стоимость: {Price} руб.\n";
        }
        protected override decimal GetDiscount()
        {
            return 0.2m;
        }
    }
}
