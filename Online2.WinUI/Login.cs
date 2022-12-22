using Online2.BLL.Abstract;
using Online2.Entity;
using Online2.Syst;
using Online2.ViewModels.UserViewModels;
using Online2.WinUI.AdminScreen;
using Online2.WinUI.EfContextInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online2.WinUI
{
    public partial class Login : Form
    {
        private readonly IUserBLL _userBLL;

        public Login(IUserBLL userBLL)
        {
            _userBLL = userBLL;

            InitializeComponent();
        }

        private void Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            string tag = btn.Tag.ToString();

            switch (tag)
            {
                case "1": LoginIn();
                    break;
                case "2": NewRegister();
                    break;
            } 
        }

        private void NewRegister()
        {
            Form frm = EFContextForm.ConfigureServices<Register>();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void LoginIn()
        {

            string userName = txtUserName.Text;
            string password = txtPassword.Text;

            LoginVM login = new LoginVM
            {
                UserName = userName,
                Password = password
            };

            ResultService<User> user = _userBLL.Login(login);

            GetUserTypes(user);
        }

        private void GetUserTypes(ResultService<User> user)
        {
            if (user.HasError)
            {
                string errorMessage = user.ErrorItems.ToList()[0].ErrorMessage;
                string errorType = user.ErrorItems.ToList()[0].ErrorType;

                MessageBox.Show(errorMessage, errorType, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Form frm = default;

                if (user.Data.UserTypes == UserTypes.Admin)
                {
                    frm = EFContextForm.ConfigureServices<AdminForm>();
                }
                else
                {

                }

                frm.ShowDialog();
                this.Close();
            }

        }

    }
}
