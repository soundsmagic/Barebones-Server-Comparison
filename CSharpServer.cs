using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Barebones_Web_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress iPAddress = IPAddress.Parse("127.0.0.1");
            IPEndPoint localEndPoint = new IPEndPoint(iPAddress, 8000);
            listener.Bind(localEndPoint);
            listener.Listen(10);
            Socket connection = listener.Accept();
            Console.WriteLine("Connected by: " + ((IPEndPoint)connection.RemoteEndPoint).Address.ToString());
            byte[] data = new Byte[1024];
            int bytesReceived = connection.Receive(data);
            string response = "HTTP/1.1 200 OK\r\nServer: My CSharpic Server\r\nAccept-Ranges: bytes\r\nContent-Length: " + data.Length.ToString() + "\r\nContent-Type: text/html\r\n\r\n" + Encoding.UTF8.GetString(data, 0, bytesReceived);
            connection.Send(Encoding.UTF8.GetBytes(response));
            Console.WriteLine("Connection terminated");
            connection.Close();
        }
    }
}
