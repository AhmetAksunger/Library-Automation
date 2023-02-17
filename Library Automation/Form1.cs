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
    public partial class Form1 : Form
    {
        //LOGIN FORM

        RegisterManager registerManager = new RegisterManager();
        BookManager bookManager = new BookManager();
        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand loginCommand = new SqlCommand("Select * from LibraryMembers where UserName=@pUserName and Password=@pPassword",SqlOperations.connection);
            loginCommand.Parameters.AddWithValue("pUserName", txtUsername.Text);
            loginCommand.Parameters.AddWithValue("pPassword", txtPassword.Text);

            SqlOperations.connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(loginCommand);
            DataTable dt = new DataTable();
            da.Fill(dt);
            SqlOperations.connection.Close();
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0][6].ToString()== "admin     " || dt.Rows[0][6].ToString() == "admin" ||
                    dt.Rows[0][6].ToString() == "Admin")
                {
                    MessageBox.Show("Logged in as an admin");
                    LoggedWith.loggedID = int.Parse(dt.Rows[0][0].ToString());
                    LoggedWith.loggedFirstName = dt.Rows[0][4].ToString();
                    LoggedWith.loggedLastName = dt.Rows[0][5].ToString();
                    LoggedWith.role = "admin    ";
                    this.Hide();
                    AdminPanel adminPanel = new AdminPanel();
                    adminPanel.Show();
                }
                else
                {
                    MessageBox.Show("Logged in succeesfully");
                    MemberPanel memberPanel = new MemberPanel();
                    LoggedWith.loggedID = int.Parse(dt.Rows[0][0].ToString());
                    LoggedWith.loggedFirstName = dt.Rows[0][4].ToString();
                    LoggedWith.loggedLastName = dt.Rows[0][5].ToString();
                    LoggedWith.role = "member   ";
                    memberPanel.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Either the username or the password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void checkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            bool checkUsername = true;
            //Check if there is a user named as the same username

            //Note that if SqlOperations.SqlUserNameCheck returns true that means there is a user with the same username before

            if (SqlOperations.SqlUserNameCheck(txtRegisterUsername.Text))
            {
                MessageBox.Show("The username " + txtRegisterUsername.Text + " already exists.\nPlease set another username","Username Exists",MessageBoxButtons.OK,MessageBoxIcon.Error);
                checkUsername = false;
            }




            bool check = true;
            foreach (var control in RegisterPanel.Controls)
            {
                if(control is TextBox textbox && textbox.Text == "")
                {
                    MessageBox.Show("You have to fill every part","Missing Part",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    check = false;
                    break;
                }
            }
           if (txtRegisterPassword.Text == txtRegisterConfirmPassword.Text && check && checkUsername)
            {
                MessageBox.Show("You've succeesfully registered!", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                registerManager.Add(txtRegisterUsername.Text, txtRegisterPassword.Text,txtRegisterFirstName.Text,txtRegisterLastName.Text,"member    ",int.Parse(txtRegisterAge.Text));

            }
            else if(txtRegisterPassword.Text != txtRegisterConfirmPassword.Text && check)
            {
                MessageBox.Show("Passwords don't match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
                

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
