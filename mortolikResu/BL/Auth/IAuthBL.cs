using System.ComponentModel.DataAnnotations;
using mortolikResu.DAL.Models;

namespace mortolikResu.BL.Auth;

public interface IAuthBL
{
    Task<int> CreateUser(UserModel user);
    
}