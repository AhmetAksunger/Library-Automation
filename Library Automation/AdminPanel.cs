using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Automation
{
    public partial class AdminPanel : Form
    {
        string role = null;
        RegisterManager registerManager = new RegisterManager();
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            GetAllMembers();
            lblLoggedWith.Text = "Logged as " + LoggedWith.loggedFirstName + " " + LoggedWith.loggedLastName;
        }

        public void GetAllMembers()
        {
            SqlOperations.connection.Open();
            SqlCommand cmd = new SqlCommand("Select * from LibraryMembers",SqlOperations.connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataMembers.DataSource = dt;
            SqlOperations.connection.Close();
        }
        public void FillTextBoxes()
        {
            try
            {
                int rowIndex = dataMembers.CurrentRow.Index;
                txtID.Text = dataMembers.Rows[rowIndex].Cells[0].Value.ToString();
                txtUserName.Text = dataMembers.Rows[rowIndex].Cells[1].Value.ToString();
                txtPassword.Text = dataMembers.Rows[rowIndex].Cells[2].Value.ToString();
                txtAge.Text = dataMembers.Rows[rowIndex].Cells[3].Value.ToString();
                txtFirstName.Text = dataMembers.Rows[rowIndex].Cells[4].Value.ToString();
                txtLastName.Text = dataMembers.Rows[rowIndex].Cells[5].Value.ToString();
                comboBoxRole.Text = dataMembers.Rows[rowIndex].Cells[6].Value.ToString();
            }
            catch (Exception)
            {
            }
            
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (SqlOperations.SqlUserNameCheck(txtUserName.Text))
            {
                //the username already exists error

                MessageBox.Show("The username " + txtUserName.Text + " already exists.\nPlease set another username", "Username Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                role = comboBoxRole.Text;
                registerManager.Add(txtUserName.Text, txtPassword.Text, txtFirstName.Text, txtLastName.Text, role, Convert.ToInt32(txtAge.Text));
                
            }
            GetAllMembers();
        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxRole.SelectedItem.ToString() == "Admin" || comboBoxRole.SelectedItem.ToString() == "admin    ")
            {
                role = "admin  ";
            }
            else
            {
                role = "member  ";
            }
        }

        private void dataMembers_SelectionChanged(object sender, EventArgs e)
        {
            FillTextBoxes();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control control in adminGroupBox.Controls)
            {
                if(control is TextBox textBox)
                {
                    textBox.Text = "";
                }else if (control is ComboBox comboBox)
                {
                    comboBox.Text = "";
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            registerManager.Delete(int.Parse(txtID.Text));
            GetAllMembers();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            registerManager.Update(txtUserName.Text, txtPassword.Text, txtFirstName.Text, txtLastName.Text, comboBoxRole.Text, int.Parse(txtAge.Text), int.Parse(txtID.Text));
            GetAllMembers();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 loginPage = new Form1();
            BookManagerForm bookManagerForm = new BookManagerForm();
            LoggedWith.loggedFirstName = null;
            LoggedWith.loggedLastName = null;
            LoggedWith.loggedID = -1;
            MessageBox.Show("Logged out","Information",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            loginPage.Show();
            bookManagerForm.Hide();
            this.Hide();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if(comboBoxFilter.SelectedItem.ToString() == "Admin")
            {
                GetAdmins();
            }
            else if(comboBoxFilter.SelectedItem.ToString() == "Member")
            {
                GetMembers();
            }
            else
            {
                GetAllMembers();
            }
        }

        public void GetAdmins()
        {
            SqlOperations.connection.Open();
            SqlCommand getAdmin = new SqlCommand("Select * from LibraryMembers where Role=@pRole",SqlOperations.connection);

            getAdmin.Parameters.AddWithValue("@pRole", "admin   ");

            SqlDataAdapter daForAdmin = new SqlDataAdapter(getAdmin);
            DataTable dtForAdmin = new DataTable();
            daForAdmin.Fill(dtForAdmin);
            dataMembers.DataSource = dtForAdmin;
            SqlOperations.connection.Close();
        }

        public void GetMembers()
        {
            SqlOperations.connection.Open();
            SqlCommand getMembers = new SqlCommand("Select * from LibraryMembers where Role=@pRole", SqlOperations.connection);

            getMembers.Parameters.AddWithValue("@pRole", "member    ");

            SqlDataAdapter daForMember = new SqlDataAdapter(getMembers);
            DataTable dtForMember = new DataTable();
            daForMember.Fill(dtForMember);
            dataMembers.DataSource = dtForMember;
            SqlOperations.connection.Close();
        }

        private void btnEditBooks_Click(object sender, EventArgs e)
        {
            BookManagerForm bookManagerForm = new BookManagerForm();
            bookManagerForm.Show();

        }

        private void AdminPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
