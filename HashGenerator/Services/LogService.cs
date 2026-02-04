using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HashGenerator.Models;

namespace HashGenerator.Services
{
    public class LogService
    {
        private const string _directoryName = "Data";
        private const string _filePath = "Data/log.txt";

        public LogService()
        {
            if (!Directory.Exists(_directoryName))
            {
                Directory.CreateDirectory(_directoryName);
            }
        }

        public void AddLog(Log log)
        {
            SaveToFile(log);
        }

        private void SaveToFile(Log log)
        {
            string fileLine = $"{log.Id};{log.Date};{log.PasswordInput};{log.Hash}";

            using StreamWriter writer = new StreamWriter(_filePath, append: true);
            writer.WriteLine(fileLine);
        }

        public List<Log> GetAllLogs()
        {
            var logs = new List<Log>();

            using (var reader = new StreamReader(_filePath))
            {
                while(!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var splitter = line.Split(';');

                    var log = new Log
                    (
                        int.Parse(splitter[0]),
                        DateTime.Parse(splitter[1]),
                        splitter[2],
                        splitter[3]
                    );

                    logs.Add(log);
                }
            }

            return logs;
        }
    }
}
