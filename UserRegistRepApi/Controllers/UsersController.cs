using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using System.Reflection.Metadata.Ecma335;
using UserRegistRepApi.Core.Models;
using UserRegistRepApi.Core.Repositories;

namespace UserRegistRepApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IBaseRepository<UsersTBL> userRep;
        public UsersController(IBaseRepository<UsersTBL> _userRep)
        {
            userRep=_userRep;
        }

        [HttpGet]
        public IActionResult GetDetails(int id)
        {
            return Ok(this.userRep.GetByID(id));

        }

        [HttpGet("GetDetailsAsync")]
        public async Task<IActionResult> GetDetailsAsync(int id)
        {
            return Ok(await this.userRep.GetByIDAsync(id));
        }

        [HttpGet("GetListAsync")]
        public async Task<ActionResult<IEnumerable<UsersTBL>>> GetAllAsync()
        {
            return Ok(await this.userRep.GetItemsAsync());
        }

        [HttpGet("GetList")]
        public ActionResult<IEnumerable<UsersTBL>> GetAll() {
            return Ok(this.userRep.GetItems());
        }

        [HttpGet("GetByData")]
        public IActionResult Find(string Name) => Ok(this.userRep.Find(u => u.UserName.Contains(Name)));
    }
}
