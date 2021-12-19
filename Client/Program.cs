using Microsoft.AspNetCore.SignalR.Client;
using System;

namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var connection = new HubConnectionBuilder()
                .WithUrl("https://localhost:5001/hub")
                .Build();

            connection.StartAsync().Wait();
            connection.On("xyz", (string userName, string message) =>
            {
                Console.WriteLine($"{userName} -- {message}");
            });
            Console.ReadKey();
        }
    }
}
