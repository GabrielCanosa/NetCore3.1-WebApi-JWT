using LoginService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginService.Interfaces
{
    public interface IUserService
    {
        void CreateUser(ApplicationUser user);
        bool EditarUsuario(ApplicationUser user);
        bool EliminarUsuario(string userID);
        ApplicationUser GetUserById(string id);
        List<ApplicationUser> GetAll();
    }
}
