using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashGenerator.Providers
{
    public class PasswordProvider
    {
        public string GenerateHash(string userPassword)
        {
            string hash = BCrypt.Net.BCrypt.HashPassword(userPassword, 13);
            return hash;
        }
    }
}
