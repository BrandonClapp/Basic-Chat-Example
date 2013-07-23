using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ChatServer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TcpClient> clientsList = new List<TcpClient>();

            TcpListener listener = new TcpListener(IPAddress.Any, 8888);
            listener.Start();
            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                clientsList.Add(client);
                new Thread(() =>
                {
                    try
                    {
                        StreamReader reader = new StreamReader(client.GetStream());
                        StreamWriter writer = new StreamWriter(client.GetStream());
                        writer.WriteLine("Welcome");
                        writer.Flush();

                        while (true)
                        {
                            string line = reader.ReadLine();
                            foreach (TcpClient c in clientsList)
                            {
                                StreamWriter ConnectedClientsWriter = new StreamWriter(c.GetStream());
                                ConnectedClientsWriter.WriteLine(line);
                                ConnectedClientsWriter.Flush();
                            }
                        }
                    }
                    catch
                    {
                        clientsList.Remove(client);
                    }
                }).Start();
            }
        }
    }
}
