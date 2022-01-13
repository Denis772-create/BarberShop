using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barber_Shop_Project.Models.Repositories.Abstract
{
    public interface IUserRepositories
    {
        Task<User> GetUserAsync(string userName);
    }
}