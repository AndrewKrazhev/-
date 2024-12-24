using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДемоЭкз
{
    static public class Helper
    {

       public static bool CheckUser(string userName, string pwd)
        {
            /*
            if (userName == "admin" && pwd == "admin") {  return true; } 
            else { return false; }
            */
            switch (userName) { 
                case "admin": if (pwd == "admin") { return true; }; break;
                case "odmin": if (pwd == "1234") { return true; }; break;

                default: return false;
            }
                
        }

    }
}
