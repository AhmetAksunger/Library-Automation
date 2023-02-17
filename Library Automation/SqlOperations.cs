using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Library_Automation
{
    public class SqlOperations
    {
        public static SqlConnection connection = new SqlConnection("Data Source=AHMEET\\MYSQLSERVER2;Initial Catalog=LibraryAutomationSQL;Integrated Security=True");
        public static SqlCommand selectCommand;
        public static SqlDataAdapter da;
        public static DataTable dt;
        //Sql select command. It was too long so I decided to move it from the MemberPanel.cs to SqlOperations.cs
        public static void SqlSelectCommand(string searchText)
        {
            selectCommand = new SqlCommand($"SELECT * FROM LibraryBooks WHERE CONCAT(BookName, AuthorName, Language, Genre, YearOfPublication) LIKE '%{searchText}%'", connection);
            da = new SqlDataAdapter(selectCommand);
            dt = new DataTable();
            da.Fill(dt);
        }

        public static bool SqlUserNameCheck(string userName)
        {
            SqlOperations.connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM LibraryMembers WHERE UserName=@pUserName",SqlOperations.connection);
            cmd.Parameters.AddWithValue("@pUserName", userName);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            connection.Close();

            if (dataTable.Rows.Count > 0) // There is a username which is named as the given username
            {
                return true;
            }
            else
            {
                return false;
            }

            
        }
        

    }
}
