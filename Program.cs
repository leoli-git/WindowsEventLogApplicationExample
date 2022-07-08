using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEventLog_應用範例
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LogHelper.Information($"這是 Event Log 應用範例");
        }
    }

    public static class LogHelper
    {
        private static string Source => ".Net Runtime"; // 基本上一定會出現的資源名稱

        public static void Information(string content)
        {
            try
            {
                System.Diagnostics.EventLog.WriteEntry(Source, content, System.Diagnostics.EventLogEntryType.Information);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"EventLog.WriteEntry Exception: {ex}");
            }
            finally
            {
                Console.WriteLine(content);
                Console.WriteLine();
            }
        }

        public static void Warning(string content)
        {
            try
            {
                System.Diagnostics.EventLog.WriteEntry(Source, content, System.Diagnostics.EventLogEntryType.Warning);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"EventLog.WriteEntry Exception: {ex}");
            }
            finally
            {
                Console.WriteLine(content);
                Console.WriteLine();
            }
        }

        public static void Error(string content)
        {
            try
            {
                System.Diagnostics.EventLog.WriteEntry(Source, content, System.Diagnostics.EventLogEntryType.Error);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"EventLog.WriteEntry Exception: {ex}");
            }
            finally
            {
                Console.WriteLine(content);
                Console.WriteLine();
            }
        }
    }
}
