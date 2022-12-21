using Online2.BLL.Abstract;
using Online2.WinUI.AdminScreen.CategoryScreen;
using Online2.WinUI.AdminScreen.FoodScreen;
using Online2.WinUI.AdminScreen.MealScreen;
using Online2.WinUI.AdminScreen.UserScreen;
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

namespace Online2.WinUI.AdminScreen
{
    public partial class AdminForm : Form
    {
        private readonly IUserBLL _userBLL;
        public AdminForm(IUserBLL userBLL)
        {
            _userBLL = userBLL;
            InitializeComponent();
        }

        private void Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;

            string tag = item.Tag.ToString();

            Form frm = default;

            switch (tag)
            {
                case "1":
                    frm = EFContextForm.ConfigureServices<UserForm>();
                    break;
                case "2":
                    frm = EFContextForm.ConfigureServices<CategoryForm>();
                    break;
                case "3":
                    frm = EFContextForm.ConfigureServices<FoodForm>();
                    break;
                case "4":
                    frm = EFContextForm.ConfigureServices<MealForm>();
                    break;
            }

            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
    }
}
