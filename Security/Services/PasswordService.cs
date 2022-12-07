using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.Services
{
    public class PasswordService
    {
        public bool IsValidPassword(string password)
        {
            //not implemented
            return true;
        }
        public string GenerateNewRandomPasswordEncrypted()
        {
            //not implemented
            return "";
        }
        private string EncryptPassword(string password)
        {
            //not implemented
            return "";
        }
        private string DecryptPassword(string encryptedPassword)
        {
            //not implemented
            return "";
        }
        public bool IsCorrectPassword(string loginName, string password)
        {
            //not implemented
            return true;
        }
    }
}
