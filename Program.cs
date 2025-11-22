using System;

namespace SafeAI_Agent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SafeAI-Agent started...");
            var monitor = new ProcessMonitor();
            monitor.Start();
            Console.WriteLine("Monitoring active. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
