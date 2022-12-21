using Online2.Entity;
using Online2.Syst;
using Online2.ViewModels.UserViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online2.BLL.Abstract
{
    public interface IUserBLL : IBaseBLL<User>
    {
        ResultService<User> CreateUser(UserCreateVM vm);

        ResultService<User> Login(LoginVM vm);

        bool AnyUser(UserCreateVM vm);

        bool IsValidEmail(string email);

        ResultService<User> GetUserByUserName(string userName);

        ResultService<User> GetUserById(int id);

        ResultService<User> UpdateUser(UserUpdateVM vm);

        ResultService<User> DeleteUser(UserBaseVM vm);
    }
}
