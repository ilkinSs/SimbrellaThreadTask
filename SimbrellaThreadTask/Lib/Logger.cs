using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SimbrellaThreadTask.Lib
{
    public static class Logger
    {
        private static readonly object balanceLock = new object();
        private static List<string> messages = new List<string>();

        public static void LogIntoFile(string message)
        {
            lock (balanceLock)
            {
                string fileName = @"C:\\Users\\ilkin\\source\\repos\\SimbrellaThreadTask\\SimbrellaThreadTask\\Files\\Data.txt";

                if (!File.Exists(fileName))
                {
                    using (FileStream fs = File.Create(fileName))
                    {
                        fs.Close();
                    }
                }

                if (messages.Count >= 100)
                {
                    File.AppendAllLines(fileName, messages);
                     
                    messages.Clear();
                }
             
            }

             
                messages.Add(message);
                //Console.WriteLine(messages.Count);
            
        }

    }
}
