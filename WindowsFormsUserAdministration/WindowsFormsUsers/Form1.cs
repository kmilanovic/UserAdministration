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
            if (DataGridViewUsers.CurrentCell.ColumnIndex.Equals(6) && e.RowIndex != -1)
            {
                FormDeleteUser FormDeleteUser = new FormDeleteUser(this);
                FormDeleteUser.nID = DataGridViewUsers.Rows[e.RowIndex].Cells[0].Value.ToString();
                FormDeleteUser.sName = DataGridViewUsers.Rows[e.RowIndex].Cells[1].Value.ToString();
                FormDeleteUser.sSurname = DataGridViewUsers.Rows[e.RowIndex].Cells[1].Value.ToString();
                FormDeleteUser.sPassword = DataGridViewUsers.Rows[e.RowIndex].Cells[2].Value.ToString();
                FormDeleteUser.sUsername = DataGridViewUsers.Rows[e.RowIndex].Cells[3].Value.ToString();
                FormDeleteUser.Show();
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FormAddUser AddNewUser = new FormAddUser(this);
            AddNewUser.Show(); 
        }

        private void btnClose2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void izlazToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
