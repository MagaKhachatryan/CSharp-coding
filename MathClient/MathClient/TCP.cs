using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MathClient
{
    public class TCP : INetWorkService
    {

        Int32 port = 8001;
        string localAddr = "127.0.0.1";
       
        public void SendResult()
        {
            try
            {
                TcpClient client = new TcpClient();
                Console.WriteLine("Connecting....");
                client.Connect(localAddr, port);
                Console.WriteLine("Connected!!!");
                Stream stream = client.GetStream();

                string str = Console.ReadLine();

                byte[] bytes = ASCIIEncoding.ASCII.GetBytes(str);
                Console.WriteLine("Transmitting...");
                stream.Write(bytes, 0, bytes.Length);
                byte[] readed = new byte[150];
                int readedBytes = stream.Read(readed, 0, 150);
                for (int i = 0; i < readedBytes; ++i)
                {
                    Console.Write(Convert.ToChar(readed[i]));
                }

                stream.Close();
                client.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error has occured" + " " + ex.Message);
            }

        }
    }
}
