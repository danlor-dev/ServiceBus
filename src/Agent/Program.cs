using System;

namespace Datev.AminOO.ServiceBus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        private static async void Init(string[] args)
        {
            // AppDomain.CurrentDomain.UnhandledException 
            AppDomain.CurrentDomain.UnhandledException += (sender, UnhandledExceptionEventArgs eventArgs) =>
            {
                // TODO: Write Logging
            };
        }
    }
}
