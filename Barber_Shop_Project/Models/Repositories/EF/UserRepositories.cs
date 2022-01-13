using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Barber_Shop_Project.Models.Repositories.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Barber_Shop_Project.Models.Repositories.EF
{
    public class UserRepositories : IUserRepositories
    {
        private readonly BSDbContext _bsDbContext;

        public UserRepositories(BSDbContext bsDbContext)
        {
            this._bsDbContext = bsDbContext;
        }

        public async Task<User> GetUserAsync(string userName)
        {
            return await _bsDbContext.User.Where(user => userName == user.UserName).Select(a => a)
                  .FirstOrDefaultAsync();
        }
    }
}