using System;
using System.IO;

namespace WebEnvironment.Helper
{
    public static class LogFileSystemHelper
    {
        public static void LogFile(string preMessage, Exception ex)
        {
            try
            {            
                var path = @"C:\Users\Altamir Dias\Downloads\Nova pasta\file.log";

                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine(DateTime.Now.ToString());
                        sw.WriteLine(string.Concat("Message: ", preMessage, ex.Message));
                        sw.WriteLine(string.Concat("StackTrace: ", ex.StackTrace));
                        sw.WriteLine(string.Concat("InnerException: ", ex.InnerException));
                    }
                }
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(DateTime.Now.ToString());
                    sw.WriteLine(string.Concat("Message: ", preMessage, ex.Message));
                    sw.WriteLine(string.Concat("StackTrace: ", ex.StackTrace));
                    sw.WriteLine(string.Concat("InnerException: ", ex.InnerException));
                }
            }catch(Exception exIntern)
            {
                LogEmailHelper.LogMail(exIntern);
            }
        }
    }
}
