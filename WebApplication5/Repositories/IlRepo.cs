using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApplication5;
using WebApplication5.DbOperations;

namespace WebApplication5.Repositories
{
    public class IlRepo : Repository<Il> , IilRepo
    {
        public IlRepo(ApiDbContext context) : base(context)
        {
        }

        
    }
}