namespace Update.Mapper
{
    public class CategoryUpdateDTO
    {
        public int Id { get; set; }
        public string? CategoryName { get; set; }
        public string CategorryDescription { get; set; }
        public List<ProductUpdateDTO> ProductList { get; set; }
    }
}
