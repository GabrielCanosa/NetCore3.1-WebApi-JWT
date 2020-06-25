using LoginService.Context;
using LoginService.Interfaces;
using LoginService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginService.Services
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public UserService()
        {
            if (GetAll().Count == 0)
            {

            }
        }

        public UserService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public void CreateUser(ApplicationUser user)
        {
            try
            {
                _applicationDbContext.Add(user);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool EditarUsuario(ApplicationUser user)
        {
            try
            {
                ApplicationUser usuarioModificar = _applicationDbContext.ApplicationUsers.Where(x => x.Id == user.Id).FirstOrDefault();
                usuarioModificar.Email = user.Email;
                _applicationDbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                new Exception(ex.Message);
            }

            return true;
        }

        public bool EliminarUsuario(string userID)
        {
            try
            {
                ApplicationUser usuario = _applicationDbContext.ApplicationUsers.Where(x => x.Id == userID).FirstOrDefault();
                _applicationDbContext.ApplicationUsers.Remove(usuario);
                _applicationDbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                new Exception(ex.Message);
            }

            return true;
        }

        public List<ApplicationUser> GetAll()
        {
            return _applicationDbContext.ApplicationUsers.ToList();
        }

        public ApplicationUser GetUserById(string id)
        {
            return _applicationDbContext.ApplicationUsers.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
