using System.Threading.Tasks;
using MeetingApp.API.Models;

namespace MeetingApp.API.Data
{
    public interface IAuthRepository
    {
        Task<User> Register (User user, string password);
        Task<User> Login(string username, string password);
        Task<bool> UserExist (string username);

    }
}