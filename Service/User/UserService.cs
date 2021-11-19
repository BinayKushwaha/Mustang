using Mustang.Database.Entity;
using Mustang.Database.Repository;
using Mustang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mustang.Service.User
{
    public class UserService:IUserService
    {
        private readonly IRepository<ApplicationUser, int> _userRepository;
        public UserService(IRepository<ApplicationUser, int> userRepository) 
        {
            this._userRepository = userRepository;
        }
        public async Task<List<UserViewModel>> GetAllAsync() 
        {
            var users =await _userRepository.GetAllAsync();
            return users.Select(a => new UserViewModel() { 
            UserName=a.UserName
            }).ToList();
        }
    }
}
