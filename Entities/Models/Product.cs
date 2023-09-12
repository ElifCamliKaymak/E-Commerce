﻿using System.ComponentModel.DataAnnotations;

namespace Entities.Models;

public class Product
{
    public int ProductId { get; set; }
    [Required(ErrorMessage = "Prodocut name is required.")]
    public string? ProductName { get; set; }
    
    [Required(ErrorMessage = "Price name is required.")]
    public decimal Price { get; set; }

    public int? CategoryId { get; set; }
    public Category? Category { get; set; }
}
