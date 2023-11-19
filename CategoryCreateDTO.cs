namespace Update.Mapper
{
    public class CategoryCreateDTO
    {
        public string CategoryName { get; set; }
        public string CategorryDescription { get; set; }
        public List<ProductCreateDTO> ProductList { get; set; }
    }
}
