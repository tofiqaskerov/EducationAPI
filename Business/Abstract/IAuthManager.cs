using Core.Entities.Concrete;
using Core.Helpers.Results;
using Core.Helpers.Results.Abstract;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAuthManager
    {
        IDataResult<User> Register(RegisterDTO registerDTO);
        IDataResult<User> Login(LoginDTO loginDTO);
    }
}