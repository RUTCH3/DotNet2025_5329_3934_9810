using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public static class LogManager
    {
        private static readonly string logDirectoryRelativePath = "Log";
        private static readonly string logDirectoryPath = Path.Combine(GetCurrentDirectory(), logDirectoryRelativePath);
        private static readonly string logFilePath = Path.Combine(logDirectoryPath, "log.txt");

        public static void WriteToLog(string message, [CallerMemberName] string funcName = "unknown", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
        {
            Directory.CreateDirectory(logDirectoryPath);
            string fileName = Path.GetFileName(filePath);
            string projectName = Assembly.GetEntryAssembly()?.GetName().Name ?? "UnknownProject";
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            if (!File.Exists(logFilePath))
            {
                File.Create(logFilePath).Close();
            }

            string logEntry = $"[{timestamp}] [{projectName}] {fileName}:{lineNumber} ({funcName}) - {message}";

            Console.WriteLine($"[{timestamp}] [{projectName}] {fileName}:{lineNumber} ({funcName}) - {message}");

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

    }
}

