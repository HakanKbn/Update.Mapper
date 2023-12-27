using AutoMapper;
using AutoMapper.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Update.Mapper.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly MyContext _myContext;

        public ValuesController(MyContext myContext, IMapper mapper)
        {
            _myContext = myContext;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CategoryCreateDTO categoryCreateDTO) 
        {
            Category category = _mapper.Map<Category>(categoryCreateDTO);
            await _myContext.AddAsync(category);
            await _myContext.SaveChangesAsync();
            return Ok();
        }
        [HttpGet]
        public async Task<ActionResult<CategoryDTO>> Get(int Id)
        {
            var A = await _myContext.Categories.Include(x => x.ProductList).Where(x => x.Id == Id).FirstOrDefaultAsync();
            var aa = _mapper.Map<CategoryDTO>(A);
            return Ok(aa);
        }
        
        [HttpPut]
        public async Task<IActionResult> Update(CategoryUpdateDTO categoryUpdateDTO) 
        {
            //var category = await _myContext.Categories
            //    .Persist(_mapper).InsertOrUpdateAsync<CategoryUpdateDTO>(categoryUpdateDTO);

            var category = await _myContext.Categories.Include(x => x.ProductList).Where(x => x.Id == categoryUpdateDTO.Id).FirstOrDefaultAsync();
            var a = _myContext.Entry(category).State;
            var c = _myContext.Entry(category.ProductList[0]).State;
            category = _mapper.Map<CategoryUpdateDTO, Category>(categoryUpdateDTO, category);
            var ca = _myContext.Entry(category.ProductList[0]).State;

            for (int i = 0; i < category.ProductList.Count(); i++)
            {
                for (int j = 0; j < categoryUpdateDTO.ProductList.Count; j++)
                {
                    if (categoryUpdateDTO.ProductList[i].Id == 4) //where de true olanın ıdsi
                    {
                        category.ProductList.Remove(category.ProductList.Where(x => x.Id == 4).FirstOrDefault());
                    }

                    if (category.ProductList[i].Id == categoryUpdateDTO.ProductList[j].Id)
                    {
                        category.ProductList[i] = _mapper.Map<ProductUpdateDTO, Product>( categoryUpdateDTO.ProductList[j], category.ProductList[i]);
                    }
                }
            }


            category.ProductList.AddRange(_mapper.Map<List<Product>>(categoryUpdateDTO.ProductList.Where(x => x.Id == null)));

            var b = _myContext.Entry(category).State;

            var x = _myContext.Entry(category.ProductList[0]).State;
            var y = _myContext.Entry(category.ProductList[1]).State;
            var k = _myContext.Entry(category.ProductList[2]).State;

           await _myContext.SaveChangesAsync();
   
            return Ok();
        }

    }
}
