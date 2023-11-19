namespace Update.Mapper
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string CategorryDescription { get; set; }
        public List<Product> ProductList { get; set; }
    }
}