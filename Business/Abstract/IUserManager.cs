using Core.Entities.Concrete;
using Core.Helpers.Results.Abstract;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserManager
    {
        void AddUser(User user);
        void RemoveUser(User user);
        void UpdateUser(User user);
        User GetUser(string email);
        IDataResult<List<UserListDTO>> GetAllUsers();
        IDataResult<UserListDTO> GetById(int id);
        IDataResult<UserListDTO> GetUserByEmail(string email);
    }
}
