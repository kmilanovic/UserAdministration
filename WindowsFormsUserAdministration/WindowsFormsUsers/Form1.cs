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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Crud Crud = new Crud();
            List <User> lUsers = Crud.GetUsers();
            DataGridViewUsers.DataSource = lUsers;

            DataGridViewImageColumn oEditButton = new DataGridViewImageColumn();
            oEditButton.Image = Image.FromFile("C:/Users/student/Source/pencil.png");
            oEditButton.Width = 20;
            oEditButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DataGridViewUsers.Columns.Add(oEditButton);

            DataGridViewImageColumn oDeleteButton = new DataGridViewImageColumn();
            oDeleteButton.Image = Image.FromFile("C:/Users/student/Source/delete1.png");
            oDeleteButton.Width = 20;
            oDeleteButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DataGridViewUsers.Columns.Add(oDeleteButton);

            DataGridViewUsers.AutoGenerateColumns = false;

        }

        private void DataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewUsers.Rows[e.RowIndex].Selected = true;
            if (DataGridViewUsers.CurrentCell.ColumnIndex.Equals(5) && e.RowIndex != -1)
            {
                FormEditUser FormEditUser = new FormEditUser(this);
                FormEditUser.lblEditUserID.Text = DataGridViewUsers.Rows[e.RowIndex].Cells[0].Value.ToString();
                FormEditUser.lblEditUserName.Text = DataGridViewUsers.Rows[e.RowIndex].Cells[1].Value.ToString();
                FormEditUser.inptEditPassword.Text = DataGridViewUsers.Rows[e.RowIndex].Cells[2].Value.ToString();
                FormEditUser.inptEditName.Text = DataGridViewUsers.Rows[e.RowIndex].Cells[3].Value.ToString();
                FormEditUser.inptEditSurname.Text = DataGridViewUsers.Rows[e.RowIndex].Cells[4].Value.ToString();
                FormEditUser.Show();
            }
        }
    }
}
