using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library_Automation
{
    public class MemberBookManager : IMemberBookManager
    {
        public string bookName;
        public void BorrowBook(int id)
        {
            SqlOperations.connection.Open();
            SqlCommand borrowCommand = new SqlCommand("Update LibraryBooks set BookAmount = BookAmount - 1 where ID=@pID",SqlOperations.connection);
            borrowCommand.Parameters.AddWithValue("@pID", id);
            borrowCommand.ExecuteNonQuery();
            SqlOperations.connection.Close();

            SqlOperations.connection.Open();
            SqlCommand messageCommand = new SqlCommand("Select BookName from LibraryBooks where ID = @pID", SqlOperations.connection);
            messageCommand.Parameters.AddWithValue("@pID", id);
            SqlDataReader dataReader = messageCommand.ExecuteReader();
            while (dataReader.Read())
            {
                bookName = dataReader.GetString(0);
            }
            MessageBox.Show("You've borrowed the book named: " + bookName + "\nBorrow date: " + DateTime.Now.ToString("dd/MM/yyyy" + "\nYou should deliver before: " + DateTime.Now.AddDays(30).ToString("dd/MM/yyyy")),"Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            SqlOperations.connection.Close();
        }


    }
}
