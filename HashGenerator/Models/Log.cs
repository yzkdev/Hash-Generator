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
        public string Hash { get; set; }

        public Log(int id, DateTime date, string hash)
        {
            Id = id;
            Date = date;
            Hash = hash;
        }
    }
}
