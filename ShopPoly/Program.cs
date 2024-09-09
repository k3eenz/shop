using ShopPoly;

List<Product> products = new List<Product>
{
    new Toy { Name = "Машинка", Price = 1500, Material = "Пластик" },
    new Meat { Name = "Говядина", Price = 300 },
    new Drinks { Name = "Cola", Price = 100, isAlcohol = false },
    new Cloth { Name = "Куртка", Price = 2999 },
    new Book { Name = "Дубровский", Author = "А.С. Пушкин", Price = 513 }
};

Console.WriteLine("Список товаров:\n");
foreach (Product product in products)
{
    Console.WriteLine($"{product.GetInformation()}" +
        $"Цена со скидкой: {product.GetDiscountedPrice()} руб.\n\n");
}

