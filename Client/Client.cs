

using System.Net.Sockets;
using System.Net;
using System.Text;

var client = new TcpClient();

client.Connect(IPAddress.Loopback, 5000);

var stream = client.GetStream();

byte[] buffer = new byte[1024];

var readCount = stream.Read(buffer);

var msg = Encoding.UTF8.GetString(buffer, 0, readCount);


Console.WriteLine(msg);
