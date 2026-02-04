using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashGenerator.Models
{
    public class Password
    {
        public string UserPassword { get; set; }
        

        public Password(string userPassword)
        {
            UserPassword = userPassword;
        }
    }
}
