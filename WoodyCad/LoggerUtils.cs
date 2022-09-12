using Autodesk.AutoCAD.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using acadApplication = Autodesk.AutoCAD.ApplicationServices.Application;

namespace WoodyCad
{
    public class LoggerUtils
    {
        public enum LogLevel
        {
            DEBUG = 0,
            INFO = 1,
            WARN = 2,
            ERROR = 3,
            FATAL = 4
        }

        public static LogLevel Current { get; set; } = LogLevel.DEBUG;
        
        public static void Alert(string msg)
        {
            Application.ShowAlertDialog(msg);
        }

        public static void Debug(string msg)
        {
            if (Current <= LogLevel.DEBUG)
                WriteMessage(LogLevel.DEBUG, msg);
        }

        public static void Info(string msg)
        {
            if (Current <= LogLevel.INFO)
                WriteMessage(LogLevel.INFO, msg);
        }

        public static void Warn(string msg)
        {
            if (Current <= LogLevel.WARN)
                WriteMessage(LogLevel.WARN, msg);
        }

        public static void Error(string msg)
        {
            if (Current <= LogLevel.ERROR)
                WriteMessage(LogLevel.ERROR, msg);
        }

        public static void Fatal(string msg)
        {
            if (Current <= LogLevel.FATAL)
                WriteMessage(LogLevel.FATAL, msg);
        }

        private static void WriteMessage(LogLevel loglevel, string msg)
        {
            acadApplication.DocumentManager.MdiActiveDocument.Editor.WriteMessage(DateTime.Now.ToString()+ " ("+loglevel+") "+ msg + "\n");
        }
    }
}
