using System.Collections.Generic;
using WebApplication5;
using WebApplication5.DbOperations;

namespace WebApplication5.Repositories
{
    public class UserRepo : Repository<User> , IUserRepo
    {
        public UserRepo(ApiDbContext context) : base(context)
        {
        }
         
    }
}