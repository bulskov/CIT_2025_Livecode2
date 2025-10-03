
using System.Net.Sockets;
using System.Net;
using System.Text;

int port = 5000;

var server = new TcpListener(IPAddress.Loopback, port);

server.Start();
Console.WriteLine($"Server started on port {port}");

while (true)
{
    TcpClient client = server.AcceptTcpClient();
    Console.WriteLine("Client connected");
    HandleClient(client);
}

void HandleClient(TcpClient client)
{
    var stream = client.GetStream();

    var msg = "Hello form server";

    stream.Write(Encoding.UTF8.GetBytes(msg));

} 
