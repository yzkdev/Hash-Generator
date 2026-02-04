using HashGenerator.Providers;
using HashGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace HashGenerator.Services
{
    public class PasswordService
    {
        public string ValidatePassword(Password password)
        {
            PasswordProvider pProvider = new PasswordProvider();
            
            string userPassword = password.UserPassword;
            
            string hashedPassword = pProvider.GenerateHash(userPassword);

            return hashedPassword;
        }
    }
}
