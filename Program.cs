using System.Net.NetworkInformation;
using System.Text;
//Create pingSender from a class and type it to the ping class
Ping pingSender = new Ping();
PingOptions options = new PingOptions();

options.DontFragment = true;

string data = "Learn to code";
byte[] buffer = Encoding.ASCII.GetBytes(data);
int timeout = 120;
string address = "4.2.2.2";
PingReply reply = pingSender.Send(address, timeout, buffer, options);
//reply has the .notations from pingSender which we created with the Ping class
//IpStatus - object Microsoft gave us 
if (reply.Status == IPStatus.Success)
{
  Console.WriteLine("Response: {0}", reply.Status.ToString());
  Console.WriteLine("RoundTrip: {0}", reply.RoundtripTime);
   Console.WriteLine("Time to live: {0}", reply.Options?.Ttl);
    Console.WriteLine("Buffer size: {0}", reply.Buffer.Length);
}