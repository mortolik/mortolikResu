using mortolikResu.DAL.Models;
using mortolikResu.ViewModels;

namespace mortolikResu.ViewMapper;

public class AuthMapper
{
    public static UserModel MapRegistrationViewToUserModel(RegisterViewModel model)
    {
        return new UserModel()
        {
            Email = model.Email!,
            Password = model.Password!
        };
    }
}