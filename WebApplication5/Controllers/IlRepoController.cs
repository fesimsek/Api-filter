using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WebApplication5.DbOperations;
using WebApplication5.Repositories;
using WebApplication5;
using WebApplication5.Filtering;
using static WebApplication5.Filter;
using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic.Core;

namespace WebApplication5.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class IlRepoController : ControllerBase
    {
        private readonly IilRepo _ıilRepo;
        private readonly ApiDbContext context;
        

        public IlRepoController(IilRepo _ilRepo, ApiDbContext context)
        {
            _ıilRepo = _ilRepo;
            this.context = context;
        }

        
        
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var DbListGet = _ıilRepo.Get(id);
            return new JsonResult(DbListGet);
        }

        //[HttpPost]
        //public ActionResult Insert([FromBody] Il newIl)
        //{
        //   _ıilRepo.Insert(newIl);
        //    //if (IlDb != null)
        //    //    return BadRequest();
        //    return Ok();
        //}

        [HttpPut("{id}")]
        public ActionResult Update(int id, [FromBody] Il updatedIl) {

            _ıilRepo.Update(updatedIl);    
            return Ok();

        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id, [FromBody] Il deleteIl)
        {
            _ıilRepo.Delete(deleteIl);
            return Ok();
        }

        [HttpGet]
        public ActionResult Comparison()
        {
            List<Filter> filter = new List<Filter>()
            {
                new Filter { Field = "Ad" ,
                    Operator = "isnotempty" },
                

            };

            var deleg = ExpressionBuilder.GetExpression<Il>(filter).Compile();
            var filteredCollection = context.Ils.Where(deleg).ToList();
            return new JsonResult(filteredCollection);


        }

        [HttpPost]
        public ActionResult Comparison([FromBody]List<Filter> filter)
        {
            

            var deleg = ExpressionBuilder.GetExpression<Il>(filter).Compile();
            var filteredCollection = context.Ils.Where(deleg).ToList();
            return new JsonResult(filteredCollection);


        }
        
        [HttpGet]
        [Route("All")]
        public ActionResult GetAll()
        {
            var query = context.Ils.ToList();
            return new JsonResult(query);
        }
    }
}
