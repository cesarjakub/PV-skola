using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class MyServer
    {
        private TcpListener myServer;
        private bool isRunning;

        public MyServer(int port)
        {
            myServer = new TcpListener(System.Net.IPAddress.Any, port);
            myServer.Start();
            isRunning = true;
            ServerLoop();
        }

        private void ServerLoop()
        {
            Console.WriteLine("Server byl spusten");
            while (isRunning)
            {
                TcpClient client = myServer.AcceptTcpClient();
                ClientLoop(client);
            }
        }

        private void ClientLoop(TcpClient client)
        {
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
                switch (data)
                {
                    case "date":
                        dataRecive = DateTime.Now.ToString();
                    break;
                    case "help":
                    break;
                    case "ipconfig":
                    break;
                    case "exit":
                        clientConnect = false;
                        break;
                    default:
                        dataRecive = "Neznamy příkaz";
                        writer.WriteLine(dataRecive);
                        writer.Flush();
                        break;
                }

                dataRecive = data + " prijato";
                writer.WriteLine(dataRecive);
                writer.Flush();
            }
            writer.WriteLine("Byl jsi odpojen");
            writer.Flush();
        }
    }
}
