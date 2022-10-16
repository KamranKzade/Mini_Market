using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_5.Models;

public class Product
{
    public string? PictureUrl { get; set; } 
    public string? ProductName { get; set; }
    public decimal Price { get; set; }
    public byte Count { get; set; } = 0;
    public bool Checked { get; set; }

    public Product(string picture, string? productName, decimal price, byte count, bool @checked)
    {
        PictureUrl = picture;
        ProductName = productName;
        Price = price;
        Count = count;
        Checked = @checked;
    }
}