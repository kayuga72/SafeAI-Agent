using System;
using System.Diagnostics;

namespace SafeAI_Agent
{
    public class ProcessMonitor
    {
        public void Start()
        {
            foreach (var process in Process.GetProcesses())
            {
                if (IsSuspicious(process))
                {
                    Console.WriteLine($"[ALERT] Suspicious process detected: {process.ProcessName}");
                }
            }
        }

        private bool IsSuspicious(Process process)
        {
            // Simple rule: flag processes with unusual names
            return process.ProcessName.ToLower().Contains("hack") ||
                   process.ProcessName.ToLower().Contains("malware") ||
                   process.ProcessName.ToLower().Contains("suspicious");
        }
    }
}
