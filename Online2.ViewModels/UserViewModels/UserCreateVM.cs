using Online2.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online2.ViewModels.UserViewModels
{
    public class UserCreateVM
    {
        [Required(ErrorMessage = "Kullanıcı adı boş geçilemez")]
        [Display(Name = "Kullanıcı adı")]
        public string UserName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public UserTypes UserTypes => UserTypes.Standart;

        public DateTime CreateDate => DateTime.Now;

    }
}
