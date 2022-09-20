
using System.Reflection;
using ReflectionDemo;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var product = new Product
{
    Id = 1,
    Name = "Product 1",
    Description = "Product 1 Description",
    Price = 100,
    Active = true,
    ProductTypeId = 1,
    ProductType = new ProductType
    {
        Id = 1,
        TypeCode = "Type 1",
        TypeDescription = "Type 1 Description",
        Active = true
    }
};

var properties = product.GetType().GetProperties();
foreach (var property in properties)
{
    Console.WriteLine($"{property.PropertyType.ToString()} {property.Name} = {property.GetValue(product)}");
}

Console.WriteLine("Ejemplo 2: ");
typeof(Product).GetProperties().ToList().ForEach(prop =>
    { 
        Console.WriteLine(prop.Name); 
        Console.WriteLine(prop.PropertyType.ToString()); 
    });

Console.WriteLine();