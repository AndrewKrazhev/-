using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДемоЭкз
{
    public class PrgUser
    {
        public PrgUser (string password, string username)
        {
            /*
             здеся запрос в БД на проверку
             */
            Password = password;
            Username = username;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }



    }
}
