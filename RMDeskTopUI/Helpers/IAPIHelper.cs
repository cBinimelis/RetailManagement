using RMDeskTopUI.Models;
using System.Threading.Tasks;

namespace RMDeskTopUI.Helpers
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
    }
}