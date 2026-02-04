using HashGenerator.Helpers;
using HashGenerator.Services;
using HashGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashGenerator.Views
{
    public class Menu
    {
        LogService logService = new LogService();

        public void ShowMenu()
        {
            bool keepRunning = true;
            
            while(keepRunning)
            {
                Console.Clear();
                Console.WriteLine("\tWelcome to Hash Generator!\n\n");
                Console.WriteLine("Select an option:\n ");
                Console.WriteLine("(1) -\tCreate hash");
                Console.WriteLine("(2) -\tSee all created hashes");
                Console.WriteLine("(3) -\tClose app");
                Console.Write("\nOption: ");

                int option = GetUserOption();

                keepRunning = HandleOption(option, keepRunning);
            }
        }

        private int GetUserOption()
        {
            int input = InputHelper.ReadIntInput();
            return input;
        }

        private bool HandleOption(int menuOption, bool keepRunning)
        {
            switch(menuOption)
            {
                case 1:
                    Console.Clear();
                    CreateHashFlow();
                    keepRunning = AskToCloseApp();
                    break;
                case 2:
                    ShowAllLogsFlow();
                    keepRunning = AskToCloseApp();
                    break;
                case 3:
                    keepRunning = false;
                    break;
            }

            return keepRunning;
        }

        private void CreateHashFlow()
        {
            PasswordService passwordService = new PasswordService();
            Random random = new Random();

            int id = random.Next(1, 150);
            DateTime date = DateTime.Now;

            try
            {
                Console.WriteLine("\t=== Hash Generator ===\n\n");
                Console.Write("Insert the password to hash: ");
                string input = InputHelper.ReadStringInput();

                Password password = new Password(input);

                string hashedPassword = passwordService.ValidatePassword(password);

                // save log
                Log log = new Log(id, date, hashedPassword);
                logService.AddLog(log);

                Console.Clear();
                Console.WriteLine("The hashed password is:\n\n");
                Console.WriteLine($"{hashedPassword}");
                Console.ReadKey();
            } catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine($"{ex.Message}");
                Console.ReadKey();
            }
        }

        private void ShowAllLogsFlow()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("\t=== HashGenerator Logs ===\n\n");

                List<Log> logs = logService.GetAllLogs();

                foreach (Log log in logs)
                {
                    Console.WriteLine($"ID: {log.Id}");
                    Console.WriteLine($"Created At: {log.Date}");
                    Console.WriteLine($"Hash: {log.Hash}");
                    Console.WriteLine("\n===========================================\n");
                }

                Console.ReadKey();
            } catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine($"{ex.Message}");
                Console.ReadKey();
            }
        }

        private bool AskToCloseApp()
        {
            Console.Clear();
            Console.Write("Want to keep app open? (1 = Yeah / 2 = Nah): ");
            int choice = InputHelper.ReadIntInput();

            if (choice == 1)
            {
                return true;
            }
            else if (choice == 2)
            {
                Console.Clear();
                Console.WriteLine("Thanks for supporting us!");
                Console.ReadKey();
                return false;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Wrong option! We'll keep it open for ya...");
                Console.ReadKey();
                return true;
            }
        }
    }
}
