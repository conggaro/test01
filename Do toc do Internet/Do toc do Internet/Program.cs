using System;
using System.Diagnostics;
using System.Net.NetworkInformation;

namespace NetworkSpeedTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing network speed...");
            Ping ping = new Ping();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            PingReply pingReply = ping.Send("www.google.com");
            stopwatch.Stop();
            Console.WriteLine($"Ping time: {pingReply.RoundtripTime} ms");
            Console.WriteLine($"Download speed: {Math.Round(1000.0 / stopwatch.ElapsedMilliseconds * 8 * pingReply.Buffer.Length / 1024 / 1024, 2)} Mbps");
        }
    }
}
