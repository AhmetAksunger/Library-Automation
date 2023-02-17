using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library_Automation
{
    public partial class MemberPanel : Form
    {
        MemberBookManager memberBookManager = new MemberBookManager();
        LogManager logManager = new LogManager();
        int id = -1;
        public MemberPanel()
        {
            InitializeComponent();
        }

        public void GetBooks()
        {
            SqlOperations.connection.Open();
            SqlCommand cmd = new SqlCommand("Select * from LibraryBooks", SqlOperations.connection);
            SqlDataAdapter daBooks = new SqlDataAdapter(cmd);
            DataTable dtBooks = new DataTable();
            daBooks.Fill(dtBooks);
            dataBooksForMembers.DataSource = dtBooks;
            dataBooksForMembers.Columns["ID"].Visible = false;
            dataBooksForMembers.Columns["BookAmount"].Visible = false;

            for (int i = 0; i < dataBooksForMembers.RowCount - 1; i++)
            {
                if (int.Parse(dataBooksForMembers.Rows[i].Cells[2].Value.ToString()) == 0)
                {
                    dataBooksForMembers.Rows[i].Visible = false;
                }
            }

            SqlOperations.connection.Close();

        }

        public void FillTextBoxes()
        {
            try
            {
                int rowIndex = dataBooksForMembers.CurrentRow.Index;
                id = int.Parse(dataBooksForMembers.Rows[rowIndex].Cells[0].Value.ToString());
                txtBookName.Text = dataBooksForMembers.Rows[rowIndex].Cells[1].Value.ToString();
                txtAuthorName.Text = dataBooksForMembers.Rows[rowIndex].Cells[3].Value.ToString();
                txtLanguage.Text = dataBooksForMembers.Rows[rowIndex].Cells[4].Value.ToString();
                txtTotalPages.Text = dataBooksForMembers.Rows[rowIndex].Cells[5].Value.ToString();
                txtGenre.Text = dataBooksForMembers.Rows[rowIndex].Cells[6].Value.ToString();
                txtGenre.Text = dataBooksForMembers.Rows[rowIndex].Cells[6].Value.ToString();
                txtYearOfPublication.Text = dataBooksForMembers.Rows[rowIndex].Cells[7].Value.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void MemberPanel_Load(object sender, EventArgs e)
        {
            GetBooks();
            lblLoggedWith.Text = "Welcome " + LoggedWith.loggedFirstName + " " + LoggedWith.loggedLastName;

        }

        private void MemberPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            memberBookManager.BorrowBook(id);
            logManager.AddLog(memberBookManager.bookName);
            GetBooks();
        }

        private void dataBooksForMembers_SelectionChanged(object sender, EventArgs e)
        {
            FillTextBoxes();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LoggedWith.loggedFirstName = null;
            LoggedWith.loggedLastName = null;
            LoggedWith.loggedID = -1;
            this.Hide();
            var form1 = new Form1();
            form1.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlOperations.connection.Open();
            SqlOperations.SqlSelectCommand(txtSearch.Text);
            dataBooksForMembers.DataSource = SqlOperations.dt;
            SqlOperations.connection.Close();
            

        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }
    }
}
