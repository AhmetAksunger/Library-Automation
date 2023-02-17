using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library_Automation
{
    public class LogManager
    {
        public void AddLog(string bookName)
        {
            string firstName = LoggedWith.loggedFirstName;
            string lastName = LoggedWith.loggedLastName;
            SqlOperations.connection.Open();
            SqlCommand addLog = new SqlCommand("Insert into LibraryLogs (FirstName,LastName,BorrowDate,ExpirationDate,BookName) values (@pFirstName,@pLastName,@pBorrowDate,@pExpirationDate,@pBookName)", SqlOperations.connection);
            addLog.Parameters.AddWithValue("@pFirstName", firstName);
            addLog.Parameters.AddWithValue("@pLastName", lastName);
            addLog.Parameters.AddWithValue("@pBorrowDate", DateTime.Now);
            addLog.Parameters.AddWithValue("@pExpirationDate", DateTime.Now.AddDays(30));
            addLog.Parameters.AddWithValue("@pBookName", bookName);
            addLog.ExecuteNonQuery();
            SqlOperations.connection.Close();




        }

    }
}
