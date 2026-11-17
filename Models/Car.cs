using System;

namespace LogCar.Models;

public class Car
{
    public int Id { get; set; }
    public Product Product { get; set; } = new Product();
    public int Quantity { get; set; }
    public string Adress { get; set; } = string.Empty;
}
