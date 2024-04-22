using mortolikResu.DAL.Auth;
using mortolikResu.DAL.Models;

namespace mortolikResu.BL.Auth;

public class AuthBL: IAuthBL
{
    private readonly IAuthDal authDal;
    public AuthBL(IAuthDal authDal)
    {
        this.authDal = authDal;
    }

    public async Task<int> CreateUser(UserModel user)
    {
        return await authDal.CreateUSer(user);
    }
}