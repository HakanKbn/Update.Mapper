using System.ComponentModel.DataAnnotations;

namespace Update.Mapper
{
    public class Product
    {
        public  int Id { get; set; }
        public   DateOnly Tarih { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int CategoryId { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}