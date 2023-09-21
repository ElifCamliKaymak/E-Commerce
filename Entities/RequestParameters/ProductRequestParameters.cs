namespace Entities.RequestParameters
{
    public class ProductRequestParameters : RequestParameters
    {
        public int? CategoryId { get; set; }
        public int MinPrice { get; set; } = 0;
        public int MaxPrice { get; set; } = int.MaxValue;
        public bool ISValidPrice => MaxPrice > MinPrice;
        public int PageNumber { get; set; }  //sayfa sayısı
        public int PageSize { get; set; } //sayfadaki eleman sayısı

        public ProductRequestParameters() : this(1, 6)
        {

        }
        public ProductRequestParameters(int pageNumber, int pageSize)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
        }

    }
}