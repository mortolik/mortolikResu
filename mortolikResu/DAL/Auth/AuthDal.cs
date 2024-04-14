using mortolikResu.DAL.Models;
using Dapper;
using Npgsql;

namespace mortolikResu.DAL.Auth;

public class AuthDal: IAuthDal
{
    public async Task<UserModel> GetUser(string email)
    {
        using (var connection = new NpgsqlConnection(DbHelper.ConnString))
        {
            connection.Open();
            return await connection.QueryFirstOrDefaultAsync<UserModel>(@"
                   select UserId, Email,Password, Salt, Status
                    from AppUser
                    where Email = @email", new {email = email}) ?? new UserModel();

        }
    }
    public async Task<UserModel> GetUser(int id)
    {
        using (var connection = new NpgsqlConnection(DbHelper.ConnString))
        {
            connection.Open();
            return await connection.QueryFirstOrDefaultAsync<UserModel>(@"
                   select UserId, Email,Password, Salt, Status
                    from AppUser
                    where UserId = @id", new {id = id}) ?? new UserModel();
        }
    }
    public async Task<int> CreateUSer(UserModel model)
    {
        using (var connection = new NpgsqlConnection(DbHelper.ConnString))
        {
            connection.Open();
            string sql = @"insert into AppUser(Email,Password, Salt, Status) 
                        values(@Email, @Password, @Salt, @Status)" ;
            return await connection.ExecuteAsync(sql, model);
        }
    }
}