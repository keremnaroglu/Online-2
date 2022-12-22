using Microsoft.VisualBasic.ApplicationServices;
using Online2.BLL.Abstract;
using Online2.Entity;
using Online2.Syst;
using Online2.ViewModels.UserViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User = Online2.Entity.User;

namespace Online2.WinUI
{
    public partial class Register : Form
    {
        private readonly IUserBLL _userBLL;

        public Register(IUserBLL userBLL)
        {
            _userBLL = userBLL;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            UserCreateVM vm = new UserCreateVM()
            {
                UserName = userName,
                Email = email,
                Password = password
            };

            ResultService<User> newUser = _userBLL.CreateUser(vm);

            if (newUser.HasError)
            {
                string errorMessage = newUser.ErrorItems.FirstOrDefault().ErrorMessage;
                string errorType = newUser.ErrorItems.FirstOrDefault().ErrorType;

                MessageBox.Show(errorMessage, errorType, MessageBoxButtons.OK);

            }
        }
    }
}
