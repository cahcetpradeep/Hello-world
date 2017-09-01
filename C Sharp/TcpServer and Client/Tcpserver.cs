using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

public class Tcpserver
{
	public static void main(String args[])
	{
		try
		{
		IPAddress IpAdr = IPAddress.Parse("172.21.5.99");
		TcpListener Tcplis =new TcpListener(IpAdr,8080);
		Tcplis.start();
		Console.WriteLine("Server Started");
		while(true)
		{
			Console.WriteLine("Accepted new Client Connection");
			StreamReader read=new StreamReader(client.GetStream());
			StreamWriter write=new StreamWriter(client.GetStream());
			String s=" ";
			
		}
		
		