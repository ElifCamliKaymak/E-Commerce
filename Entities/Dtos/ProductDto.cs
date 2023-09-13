using System.ComponentModel.DataAnnotations;

namespace Entities.Dtos
{
    public record ProductDto
    {
        public int ProductId { get; init; }
        [Required(ErrorMessage = "Prodocut name is required.")]
        public string? ProductName { get; init; }

        [Required(ErrorMessage = "Price name is required.")]
        public decimal Price { get; init; }
        public string? Summary { get; init; } = string.Empty;
        public string? ImageUrl { get; set; }

        public int? CategoryId { get; init; }

    }
}