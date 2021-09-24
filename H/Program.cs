
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoLibrary;

namespace H
{
    class Program
    {
        bool format = Format.GetDefaultFormat();
        static void Main(string[] args)
        {
            WriteLine("Enter The Url: ");
            var url = Console.ReadLine();
            Download(url);
            Console.ReadLine();
        }

        public static async void Download(string url)
        {
            var yt = YouTube.Default;
            var vud = await yt.GetVideoAsync(url);
            File.WriteAllBytes(Environment.CurrentDirectory + $"\\{vud.FullName}.wav", vud.GetBytes());
        }
        public static void WriteLine(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("H++");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("] " + message + "\n");
        }
    }
}
