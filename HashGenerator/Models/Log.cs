using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashGenerator.Models
{
    public class Log
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string PasswordInput { get; set; }
        public string Hash { get; set; }

        public Log(int id, DateTime date, string passwordInput, string hash)
        {
            Id = id;
            Date = date;
            PasswordInput = passwordInput;
            Hash = hash;
        }
    }
}
