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
    public partial class BookManagerForm : Form
    {
        BookManager bookManager = new BookManager();
        public BookManagerForm()
        {
            InitializeComponent();
        }

        public void GetLogs()
        {
            SqlOperations.connection.Open();
            SqlCommand getLogs = new SqlCommand("Select * from LibraryLogs", SqlOperations.connection);
            SqlDataAdapter da = new SqlDataAdapter(getLogs);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataBookLogs.DataSource = dt;
            SqlOperations.connection.Close();
        }
        public void GetBooks()
        {
            SqlOperations.connection.Open();
            SqlCommand cmd = new SqlCommand("Select * from LibraryBooks", SqlOperations.connection);
            SqlDataAdapter daBooks = new SqlDataAdapter(cmd);
            DataTable dtBooks = new DataTable();
            daBooks.Fill(dtBooks);
            dataGridViewBooks.DataSource = dtBooks;
            SqlOperations.connection.Close();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bookManager.Add(txtBookName.Text, int.Parse(txtBookAmount.Text), txtAuthorName.Text, txtLanguage.Text, int.Parse(txtTotalPages.Text), txtGenre.Text, txtYearOfPublication.Text);
            GetBooks();
        }



        private void BookManagerForm_Load(object sender, EventArgs e)
        {
            GetBooks();
            GetLogs();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bookManager.Update(txtBookName.Text, int.Parse(txtBookAmount.Text), txtAuthorName.Text, txtLanguage.Text, int.Parse(txtTotalPages.Text), txtGenre.Text, txtYearOfPublication.Text, int.Parse(txtID.Text));
            GetBooks();
        
        }

        public void FillTextBoxes()
        {
            try
            {
                int rowIndex = dataGridViewBooks.CurrentRow.Index;
                txtID.Text = dataGridViewBooks.Rows[rowIndex].Cells[0].Value.ToString();
                txtBookName.Text = dataGridViewBooks.Rows[rowIndex].Cells[1].Value.ToString();
                txtBookAmount.Text = dataGridViewBooks.Rows[rowIndex].Cells[2].Value.ToString();
                txtAuthorName.Text = dataGridViewBooks.Rows[rowIndex].Cells[3].Value.ToString();
                txtLanguage.Text = dataGridViewBooks.Rows[rowIndex].Cells[4].Value.ToString();
                txtTotalPages.Text = dataGridViewBooks.Rows[rowIndex].Cells[5].Value.ToString();
                txtGenre.Text = dataGridViewBooks.Rows[rowIndex].Cells[6].Value.ToString();
                txtGenre.Text = dataGridViewBooks.Rows[rowIndex].Cells[6].Value.ToString();
                txtYearOfPublication.Text = dataGridViewBooks.Rows[rowIndex].Cells[7].Value.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void dataGridViewBooks_SelectionChanged(object sender, EventArgs e)
        {
            FillTextBoxes();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bookManager.Delete(int.Parse(txtID.Text));
            GetBooks();
        }

        private void BookManagerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (var control in groupBoxAdminBooks.Controls)
            {
                if(control is TextBox textBox)
                {
                    textBox.Text = "";
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlOperations.connection.Open();
            SqlOperations.SqlSelectCommand(txtSearch.Text);
            dataGridViewBooks.DataSource = SqlOperations.dt;


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
