using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Automation
{
    public class RegisterManager : IRegisterManager
    {
        /*
        string userName;
        string password;
        string firstName;
        string lastName;
        int age;
        */
        public void Add(string userName, string password, string firstName, string lastName, string role, int age)
        {
            try
            {
                SqlCommand addCommand = new SqlCommand("Insert into LibraryMembers (UserName,Password,FirstName,LastName,Age,Role) values (@pUserName,@pPassword,@pFirstName,@pLastName,@pAge,@pRole)", SqlOperations.connection);
                SqlOperations.connection.Open();
                addCommand.Parameters.AddWithValue("@pUserName", userName);
                addCommand.Parameters.AddWithValue("@pPassword", password);
                addCommand.Parameters.AddWithValue("@pFirstName", firstName);
                addCommand.Parameters.AddWithValue("@pLastName", lastName);
                addCommand.Parameters.AddWithValue("@pAge", age);
                addCommand.Parameters.AddWithValue("@pRole", role);
                addCommand.ExecuteNonQuery();
                SqlOperations.connection.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show("Error: " + e.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                SqlOperations.connection.Close();
            }

        }

        public void Delete(int ID)
        {
            SqlOperations.connection.Open();
            SqlCommand deleteCommand = new SqlCommand("Delete from LibraryMembers where ID=@pID",SqlOperations.connection);
            deleteCommand.Parameters.AddWithValue("@pID", ID);
            deleteCommand.ExecuteNonQuery();
            SqlOperations.connection.Close();
        }

        public void Update(string userName, string password, string firstName, string lastName, string role, int age, int id)
        {
            SqlOperations.connection.Open();
            SqlCommand updateCommand  = new SqlCommand("UPDATE LibraryMembers set UserName = @pUserName , Password = @pPassword , FirstName = @pFirstName , LastName = @pLastName , Age = @pAge , Role= @pRole where ID = @pID", SqlOperations.connection);
            updateCommand.Parameters.AddWithValue("@pUserName", userName);
            updateCommand.Parameters.AddWithValue("@pPassword", password);
            updateCommand.Parameters.AddWithValue("@pFirstName", firstName);
            updateCommand.Parameters.AddWithValue("@pLastName", lastName);
            updateCommand.Parameters.AddWithValue("@pAge", age);
            updateCommand.Parameters.AddWithValue("@pRole", role);
            updateCommand.Parameters.AddWithValue("@pID", id);
            updateCommand.ExecuteNonQuery();
            SqlOperations.connection.Close();
        }
    }
}
