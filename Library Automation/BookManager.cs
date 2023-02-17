using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Automation
{
    public class BookManager : IBookManager
    {
        public void Add(string bookName, int bookAmount, string authorName, string language, int totalPages, string genre, string yearOfPublication)
        {
            SqlCommand addCommand = new SqlCommand("Insert into LibraryBooks (BookName,BookAmount,AuthorName,Language,TotalPages,Genre,YearOfPublication) values " +
                "(@pBookName,@pBookAmount,@pAuthorName,@pLanguage,@pTotalPages,@pGenre,@pYearOfPublication)",SqlOperations.connection);
            SqlOperations.connection.Open();
           
            addCommand.Parameters.AddWithValue("@pBookName", bookName);
            addCommand.Parameters.AddWithValue("@pBookAmount", bookAmount);
            addCommand.Parameters.AddWithValue("@pAuthorName", authorName);
            addCommand.Parameters.AddWithValue("@pLanguage", language);
            addCommand.Parameters.AddWithValue("@pTotalPages", totalPages);
            addCommand.Parameters.AddWithValue("@pGenre", genre);
            addCommand.Parameters.AddWithValue("@pYearOfPublication", yearOfPublication);
            addCommand.ExecuteNonQuery();

            SqlOperations.connection.Close();


        }


        public void Delete(int id)
        {
            SqlCommand deleteCommand = new SqlCommand("Delete from LibraryBooks where ID=@pID",SqlOperations.connection);
            SqlOperations.connection.Open();
            deleteCommand.Parameters.AddWithValue("@pID", id);
            deleteCommand.ExecuteNonQuery();
            SqlOperations.connection.Close();
        
        }

        public void Update(string bookName, int bookAmount, string authorName, string language, int totalPages, string genre, string yearOfPublication, int id)
        {
            SqlOperations.connection.Open();
            SqlCommand updateCommand = new SqlCommand("Update LibraryBooks set BookName=@pBookName, BookAmount=@pBookAmount, " +
                "AuthorName=@pAuthorName, Language=@pLanguage, TotalPages=@pTotalPages, Genre=@pGenre, YearOfPublication=@pYearOfPublication where ID=@pID", SqlOperations.connection);
            
            updateCommand.Parameters.AddWithValue("@pBookName", bookName);
            updateCommand.Parameters.AddWithValue("@pBookAmount", bookAmount);
            updateCommand.Parameters.AddWithValue("@pAuthorName", authorName);
            updateCommand.Parameters.AddWithValue("@pLanguage", language);
            updateCommand.Parameters.AddWithValue("@pTotalPages", totalPages);
            updateCommand.Parameters.AddWithValue("@pGenre", genre);
            updateCommand.Parameters.AddWithValue("@pYearOfPublication", yearOfPublication);
            updateCommand.Parameters.AddWithValue("@pID", id);
            updateCommand.ExecuteNonQuery();
            SqlOperations.connection.Close();


        }
    }
}
