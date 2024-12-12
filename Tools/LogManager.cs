using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public static class LogManager
    {
        private static readonly string logDirectoryRelativePath = "Log";
        private static readonly string logDirectoryPath = Path.Combine(GetCurrentDirectory(), logDirectoryRelativePath);
        private static readonly string logFilePath = Path.Combine(logDirectoryPath, "log.txt");

        public static void WriteToLog(string projectName, string funcName, string message)
        {
            Directory.CreateDirectory(logDirectoryPath);

            if (!File.Exists(logFilePath))
            {
                File.Create(logFilePath).Close();
            }

            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");


            string logEntry = $"{timestamp} | Project: {projectName} | Function: {funcName} | Message: {message}";

            File.AppendAllText(logFilePath, logEntry + Environment.NewLine);

            File.SetLastWriteTime(logFilePath, DateTime.Now);
        }

        public static void CleanUpOldLogDirectories()
        {
            if (Directory.Exists(logDirectoryPath))
            {
                var directories = Directory.GetDirectories(logDirectoryPath);

                foreach (var directory in directories)
                {
                    DateTime lastWriteTime = Directory.GetLastWriteTime(directory);
                    if (lastWriteTime < DateTime.Now.AddMonths(-2))
                    {
                        Directory.Delete(directory, true);
                    }
                }
            }
        }


        private static string GetCurrentDirectory()
        {
            return Directory.GetCurrentDirectory();
        }

        private static string GetCurrentFilePath()
        {
            return Assembly.GetExecutingAssembly().Location;
        }
    }
}

