using DataBaseService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsUsers
{
    public partial class FormDeleteUser : Form
    {
        private readonly Form1 FormUserList;
        public string nID;
        public string sName;
        public string sSurname;
        public string sPassword;
        public string sUsername;
        public FormDeleteUser(Form1 FormUsers)
        {
            FormUserList = FormUsers;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            User oUser = new User();
            oUser.nUserID = Int32.Parse(nID);
            oUser.sUserFirstName = sName;
            oUser.sUserLastName = sSurname;
            oUser.sUserPassword = sPassword;
            oUser.sUserName = sUsername;
            Crud Crud = new Crud();
            Crud.DeleteUsers(oUser);
            this.FormUserList.DataGridViewUsers.DataSource = Crud.GetUsers();
            this.Hide();
        }
    }
}
