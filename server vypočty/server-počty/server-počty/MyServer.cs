using server_počty.command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace server_počty
{
    public class MyServer
    {
        private TcpListener myServer;
        private bool isRunning;
        private Dictionary<string, ICommand> myCommands = new Dictionary<string, ICommand>();

        public MyServer(int port)
        {
            myServer = new TcpListener(System.Net.IPAddress.Any, port);
            myServer.Start();
            isRunning = true;
            myCommands.Add("vypocet", new OhmuvZak());
            ServerLoop();
        }

        private void ServerLoop()
        {
            Console.WriteLine("Server byl spusten");
            while (isRunning)
            {
                TcpClient client = myServer.AcceptTcpClient();
                Thread thread = new Thread(new ParameterizedThreadStart(ClientLoop));
                thread.Start(client);
            }
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
            while (clientConnect)
            {
                data = reader.ReadLine();
                data = data.ToLower();
                if (data == "end")
                {
                    clientConnect = false;
                }
                
                if (myCommands.ContainsKey(data))
                {
                    dataRecive = myCommands[data].Execute();
                }
                else
                {
                    dataRecive = "Neznamy prikaz";
                }
                dataRecive = data;
                writer.WriteLine("SERVER> "+dataRecive);
                writer.Flush();
            }
            writer.WriteLine("SERVER> Byl jsi odpojen");
            writer.Flush();
        }
    }
}
