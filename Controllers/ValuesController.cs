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

        //[HttpPost]
        //public async Task<IActionResult> Create(CategoryCreateDTO categoryCreateDTO) 
        //{
        //    Category category = _mapper.Map<Category>(categoryCreateDTO);
        //    await _myContext.AddAsync(category);
        //    await _myContext.SaveChangesAsync();
        //    return Ok();
        //}
        //[HttpGet]
        //public async Task<ActionResult<CategoryDTO>> Get(int Id)
        //{
        //    var A = await _myContext.Categories.Include(x => x.ProductList).Where(x => x.Id == Id).FirstOrDefaultAsync();
        //    var aa = _mapper.Map<CategoryDTO>(A);
        //    return Ok(aa);
        //}
        
        //[HttpPut]
        //public async Task<IActionResult> Update(CategoryUpdateDTO categoryUpdateDTO) 
        //{
        //    //var category = await _myContext.Categories
        //    //    .Persist(_mapper).InsertOrUpdateAsync<CategoryUpdateDTO>(categoryUpdateDTO);

   
        //    return Ok();
        //}

    }
}
