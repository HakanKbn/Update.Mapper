using AutoMapper;
using AutoMapper.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Update.Mapper.Model;

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
        [HttpGet]
        public IActionResult Get2() 
        {

            return Ok();
                
                
                
                }


        [HttpPost]
        public async Task<IActionResult> Create(string kod, int tipId)
        {
            Referans category = new Referans
            {
                kod = kod,
                tipId = tipId
            };
            await _myContext.AddAsync(category);
            await _myContext.SaveChangesAsync();
            return Ok();
        }
   

    }
}
