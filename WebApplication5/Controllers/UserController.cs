using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication5.DbOperations;
using WebApplication5.Repositories;


namespace WebApplication5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepo _ıUserRepo;

        public UserController(IUserRepo _UserRepo)
        {
            _ıUserRepo = _UserRepo;
        }

        [HttpGet]
        //public ActionResult GetAll()
        //{

        //    var DbList = _ıUserRepo.GetAll();
        //    return new JsonResult(DbList);
        //}
        
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var DbListGet = _ıUserRepo.Get(id);
            return new JsonResult(DbListGet);
        }

        [HttpPost]
        public ActionResult Insert([FromBody] User newUser)
        {
            _ıUserRepo.Insert(newUser);
            //if (IlDb != null)
            //    return BadRequest();
            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, [FromBody] User updatedUser) {

            _ıUserRepo.Update(updatedUser);    
            return Ok();

        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id, [FromBody] User deleteUser)
        {
            _ıUserRepo.Delete(deleteUser);
            return Ok();
        }
    }
}
