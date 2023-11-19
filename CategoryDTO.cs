namespace Update.Mapper
{
    public class CategoryDTO
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string CategorryDescription { get; set; }
        public List<ProductDTO> ProductList { get; set; }
    }
}