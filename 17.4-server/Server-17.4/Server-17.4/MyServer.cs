using Server_17._4.command;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server_17._4
{
    public class MyServer
    {

        private string LoginFilePath = @"D:\server\17.4-server\Server-17.4\Server-17.4\LogFile.txt";
        private string LogFilePath = @"D:\server\17.4-server\Server-17.4\Server-17.4\LogFile.txt";

        private TcpListener myServer;
        private bool isRunning;
        private Dictionary<string, ICommand> myCommands = new Dictionary<string, ICommand>();
        private Stopwatch timer = new Stopwatch();

        public MyServer(int port)
        {
            myServer = new TcpListener(System.Net.IPAddress.Any, port);
            myServer.Start();
            isRunning = true;
            myCommands.Add("exit", new Exit());
            myCommands.Add("last", new Last());
            myCommands.Add("stats", new Stats());
            myCommands.Add("uptime", new Uptime());
            myCommands.Add("who", new Who());
            ServerLoop();
        }

        private void ServerLoop()
        {
            Console.WriteLine("Server byl spusten");
            
            timer.Start();
            while (isRunning)
            {
                TcpClient client = myServer.AcceptTcpClient();
                Thread thread = new Thread(new ParameterizedThreadStart(ClientLoop));
                thread.Start(client);
            }
            timer.Stop();
        }

        private void ClientLoop(object myClient)
        {
            TcpClient client = (TcpClient)myClient;
            StreamReader reader = new StreamReader(client.GetStream(), Encoding.UTF8);
            StreamWriter writer = new StreamWriter(client.GetStream(), Encoding.UTF8);

            writer.WriteLine("Byl jsi pripojen");
            writer.Flush();
            bool clientConnect = true;
            string? data = null;
            string? dataRecive = null;
            Log("joe");
            while (clientConnect)
            {
                data = reader.ReadLine();
                data = data.ToLower();
                switch (data)
                {
                    case "exit":
                        clientConnect = false;
                        break;
                    case "who":
                        dataRecive = "Last";
                        writer.WriteLine(dataRecive);
                        writer.Flush();
                        break;
                    case "uptime":
                        dataRecive = $"Time elapsed: {timer.ToString()}";
                        writer.WriteLine(dataRecive);
                        writer.Flush();
                        break;
                    case "stats":
                        dataRecive = "Last";
                        writer.WriteLine(dataRecive);
                        writer.Flush();
                        break;
                    case "last":
                        dataRecive = "Last";
                        writer.WriteLine(dataRecive);
                        writer.Flush();
                        break;
                    default:
                        dataRecive = "Neznamy prikaz";
                        writer.WriteLine(dataRecive);
                        writer.Flush();
                        break;
                }
            }
            writer.WriteLine("Byl jsi odpojen");
            writer.Flush();
        }

        public void Log(string jmeno)
        {
            string text = $"{jmeno} | {DateTime.Now}";
            StreamWriter wr = new StreamWriter(LogFilePath, true);
            wr.WriteLine(text+"\n");
            wr.Close();
        }
    }
}
