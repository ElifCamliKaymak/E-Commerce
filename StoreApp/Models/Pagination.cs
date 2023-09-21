namespace StoreApp.Models
{
    public class Pagination
    {
        public int TotalItems { get; set; }  //kaç tane ürün listelendiği bilgisi
        public int ItemsPerPage { get; set; }  //sayfa başına düşen kayıt sayısı
        public int CurrenPage { get; set; }   //mevcut sayfa bilgisini tutar

        public int TotalPages =>
            (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage);

    }
}