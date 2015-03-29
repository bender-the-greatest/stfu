using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace stfu_shared
{
    public class StfuLogger
    {
        public static string LOGDIR;

        public string LogPath { get; private set; }

        static StfuLogger()
        {
            LOGDIR = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "STFU");
        }

        private static string GetLogPrefix()
        {
            DateTime time = DateTime.Now;
            return string.Format(
                "{0} {1} - ",
                time.ToShortDateString(),
                time.ToShortTimeString());
        }

        public static void ShowException(Exception e)
        {
            ShowException(e, string.Empty);
        }

        public static void ShowException(Exception e, string prefix)
        {
            ShowException(new StfuException(e), prefix);
        }

        public static void ShowException(StfuException e)
        {
            ShowException(e, string.Empty);
        }

        public static void ShowException(StfuException e, string prefix)
        {
            using (frmError fErr = new frmError(e, prefix))
                fErr.ShowDialog();
        }

        public StfuLogger(string logname)
        {
            this.LogPath = Path.Combine(LOGDIR, string.Format("{0}.log", logname));
        }

        public void LogLine(string toLog)
        {
            try
            {
                using (FileStream stream = new FileStream(this.LogPath, FileMode.Append))
                {
                    byte[] buffer = new byte[stream.Length];
                    int read;
                    while ((read = stream.Read(buffer, 0, buffer.Length)) > 0)
                        stream.Write(buffer, 0, buffer.Length);
                }
            } catch (IOException e)
            {
                throw new StfuException(e);
            }
        }
    }
}
