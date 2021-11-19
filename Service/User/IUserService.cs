using Mustang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mustang.Service.User
{
    public interface IUserService
    {
        Task<List<UserViewModel>> GetAllAsync();
    }
}
