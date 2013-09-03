using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FSAircraftRepositoryFactory
{
    public class Logger
    {
        public static bool loggingEnabled;

        public static void Log(string msg)
        {
            if (loggingEnabled)
            {
                StreamWriter log;

                if (!File.Exists("logs/repos.log"))
                {
                    log = new StreamWriter("logs/repos.log");
                }
                else
                {
                    log = File.AppendText("logs/repos.log");
                }

                if (msg == "")
                {
                    log.WriteLine("---------------------------------------------");
                }
                else
                {
                    log.WriteLine("[" + DateTime.Now + "] " + msg);
                }

                log.Close();
            }
        }

        public static void Init()
        {
            System.IO.Directory.CreateDirectory("logs");
        }
    }
}
