using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Automation
{
    public interface IRegisterManager
    {
        void Add(string userName, string password, string firstName, string lastName, string role, int age);
        void Update(string userName, string password, string firstName, string lastName, string role, int age, int id);
        void Delete(int ID);


    }
}
