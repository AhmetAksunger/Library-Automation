using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Automation
{
    public interface IBookManager
    {
        void Add(string bookName, int bookAmount, string authorName, string language, int totalPages, string genre, string yearOfPublication);

        void Update(string bookName, int bookAmount, string authorName, string language, int totalPages, string genre, string yearOfPublication, int id);

        void Delete(int id);



    }
}
