using mortolikResu.DAL.Models;

namespace mortolikResu.DAL.Auth;
public interface IAuthDal
{
  Task<UserModel> GetUser(string email);
  Task<UserModel> GetUser(int id);
  Task<int> CreateUSer(UserModel model);
}