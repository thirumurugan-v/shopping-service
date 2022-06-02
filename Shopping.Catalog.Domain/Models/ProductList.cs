namespace Shopping.Catalogue.Domain.Models
{
    public class ProductList : BaseEntity
    {
        public int ProductId { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string ThumbnailImagePath { get; set; } = string.Empty;
    }
}
