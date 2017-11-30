using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBaseService;

namespace WindowsFormsUsers
{
    public partial class FormAddUser : Form
    {
        private readonly Form1 FormUserList;

        public FormAddUser(Form1 FormUsers)
        {
            FormUserList = FormUsers;
            InitializeComponent();
        }

        private void btnClose2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave2_Click(object sender, EventArgs e)
        {
            User oUser = new User();
            oUser.sUserName = inptEditUserName.Text;
            oUser.sUserFirstName = inptEditName2.Text;
            oUser.sUserLastName = inptEditLastName2.Text;
            oUser.sUserPassword = inptEditPassword2.Text;
            Crud Crud = new Crud();
            Crud.AddUsers(oUser);
            this.FormUserList.DataGridViewUsers.DataSource = Crud.GetUsers();
            this.Hide();

        }
    }
}
