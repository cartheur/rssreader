using System;
using System.IO;

namespace RSSReader
{
    /// <summary>
    /// The class which performs logging for the library. Originated in MACOS 9.0.4 under CodeWarrior.
    /// </summary>
    public static class Logging
    {
        /// <summary>
        /// The file path for executing assemblies.
        /// </summary>
        public static string FilePath = Environment.CurrentDirectory;
        /// <summary>
        /// The type of log to write.
        /// </summary>
        [Flags]
        public enum LogType { Information, Error, Warning };
        /// <summary>
        /// The classes within the interpreter calling the log.
        /// </summary>
        public enum LogCaller { ChannelDialog, ThemeDialog, MainForm, NewsItem, ChannelItem }
        /// <summary>
        /// The last message passed to logging.
        /// </summary>
        public static string LastMessage = "";
        /// <summary>
        /// The delegate for returning the last log message to the calling application.
        /// </summary>
        public delegate void LoggingDelegate();
        /// <summary>
        /// Occurs when [returned to console] is called.
        /// </summary>
        public static event LoggingDelegate ReturnedToConsole;
        /// <summary>
        /// Logs a message sent from the calling application to a file.
        /// </summary>
        /// <param name="message">The message to log. Space between the message and log type enumeration provided.</param>
        /// <param name="logType">Type of the log.</param>
        /// <param name="caller">The class creating the log entry.</param>
        public static void WriteLog(string message, LogType logType, LogCaller caller)
        {
            LastMessage = message;
            StreamWriter stream = new StreamWriter(FilePath + @"\logs\logfile.txt", true);
            switch (logType)
            {
                case LogType.Error:
                    stream.WriteLine(DateTime.Now + " - " + " ERROR " + " - " + message + " from " + caller + ".");
                    break;
                case LogType.Warning:
                    stream.WriteLine(DateTime.Now + " - " + " WARNING " + " - " + message + " from " + caller + ".");
                    break;
                case LogType.Information:
                    stream.WriteLine(DateTime.Now + " - " + " INFO " + message);
                    break;
            }
            stream.Close();
            if (!Equals(null, ReturnedToConsole))
            {
                ReturnedToConsole();
            }
        }
        /// <summary>
        /// Writes a debug log with object parameters.
        /// </summary>
        /// <param name="objects">The objects.</param>
        public static void Debug(params object[] objects)
        {
            StreamWriter stream = new StreamWriter(FilePath + @"\logs\logfile.txt", true);
            foreach (object obj in objects)
            {
                stream.WriteLine(obj);
            }
            stream.WriteLine("--");
            stream.Close();
        }
    }
}
