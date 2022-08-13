using SOMCH.Models;
using SOMCH.Data;
using SOMCH.DTOs;

namespace SOMCH.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        private readonly Registration2Context _dbContext;
        public LoginRepository(Registration2Context dbContext)
        {
            _dbContext = dbContext;
        }



        public LoginDTO FindUser(string userName)
        {
            RegUserInfo? userToBeFound = _dbContext.RegUserInfos.FirstOrDefault(user => user.Username == userName);
            LoginDTO userDTO=new LoginDTO();
            if (userToBeFound != null)
            {
                userDTO.Username=userToBeFound.Username;
                userDTO.Password=userToBeFound.Password;    
            }
            else
            {
               return userDTO = null;
            }
            return userDTO;
        }




    }
}
