using SOMCH.DTOs;
using SOMCH.Models;

namespace SOMCH.Repositories
{
    public interface ILoginRepository
    {
        LoginDTO FindUser(string userName);

    }
}
