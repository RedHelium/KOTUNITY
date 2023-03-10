using KotunityConsole.Emulation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

namespace KOT.System
{
    public static class DebugController
    {
        private readonly static string LOG_PATH = "logs.txt";

        public enum LogType : sbyte { Message = 0, Warning = 1, Error = 2 }


        /// <summary>
        /// TODO Initialize log file
        /// </summary>
        public static void Init()
        {
            
        }

        /// <summary>
        /// TODO output log in console or write him on file
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        public static void Log(string message, GameObjectEmul calledObj = null, LogType logType = LogType.Message, bool isConsole = false, Exception exception = null)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append($"[TIMESTAMP {DateTime.Now}] | ");

            if(calledObj!= null )
            stringBuilder.Append($"[OBJECT: {calledObj.name}] | ");

            stringBuilder.Append($"[{logType.ToString().ToUpper()}]: ");
            stringBuilder.Append(exception != null ? $"{message} | EXCEPTION: {exception}" : $"{message}");
            
            if(isConsole)
                DebugEmul.Log(stringBuilder.ToString());
            else
            { 
                DebugEmul.Log(stringBuilder.ToString());

                Write(stringBuilder.ToString());
            }
        }

        private static void Write(string line)
        {
            //TODO Connect with FileManager
        }

    }
}
