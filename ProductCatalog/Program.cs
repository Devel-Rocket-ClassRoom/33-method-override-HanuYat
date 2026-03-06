using System;

// README.md를 읽고 코드를 작성하세요.

Console.WriteLine("=== 상품 카탈로그 ===");

Product[] products = new Product[]
{
    new Electronics { Name = "노트북", Price = 1500000, Warranty = 24 },
    new Clothing { Name = "청바지", Price = 89000, Size = "M" },
    new Food { Name = "우유", Price = 3500, ExpirationDate = DateTime.Now.AddMonths(6) }
};

foreach (var product in products)
{
    Console.WriteLine(product);
    product.GetDescription();
    Console.WriteLine();
}