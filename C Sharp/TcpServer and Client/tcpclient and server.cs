namespace Server
{
    class Program
    {
        const int PORT_NO = 5000;
        const string SERVER_IP = "127.0.0.1";

        static void Main(string[] args)
        {
            //---listen at the specified IP and port no.---
            IPAddress localAdd = IPAddress.Parse(SERVER_IP);
            TcpListener listener = new TcpListener(localAdd, PORT_NO);
            Console.WriteLine("Listening...");
            listener.Start();

            //---incoming client connected---
            TcpClient client = listener.AcceptTcpClient();

            //---get the incoming data through a network stream---
            NetworkStream nwStream = client.GetStream();
            byte[] buffer = new byte[client.ReceiveBufferSize];  //The size of the receive buffer, in bytes. The default value is 8192 bytes.

            //---read incoming stream---
			
			/*buffer
			Type: System.Byte[]
			An array of type Byte that is the location in memory to store data read from the NetworkStream.
			offset
			Type: System.Int32
			The location in buffer to begin storing the data to.
			size
			Type: System.Int32
			The number of bytes to read from the NetworkStrea*/
            int bytesRead = nwStream.Read(buffer, 0, client.ReceiveBufferSize);

            //---convert the data received into a string---
            string dataReceived = Encoding.ASCII.GetString(buffer, 0, bytesRead);
            Console.WriteLine("Received : " + dataReceived);

            //---write back the text to the client---
            Console.WriteLine("Sending back : " + dataReceived);
            nwStream.Write(buffer, 0, bytesRead);
            client.Close();
            listener.Stop();
            Console.ReadLine();
        }
    }
}
//this is the code for the client

namespace Client
{
    class Program
    {
        const int PORT_NO = 5000;
        const string SERVER_IP = "127.0.0.1";
        static void Main(string[] args)
        {
            //---data to send to the server---
            string textToSend = DateTime.Now.ToString();

            //---create a TCPClient object at the IP and port no.---
            TcpClient client = new TcpClient(SERVER_IP, PORT_NO);
			
			//---network stream  method reads data into the buffer parameter and returns the number of bytes successfully read. If no data is available for reading, the Read method returns 0. The Read operation reads as much data as is available, up to the number of bytes specified by the size parameter. If the remote host shuts down the connection, and all available data has been received, the Read method completes immediately and return zero bytes.---
			
			//GetStream returns a NetworkStream that you can use to send and receive data. The NetworkStream class inherits from the Stream class, which provides a rich collection of methods and properties used to facilitate network communications.
            NetworkStream nwStream = client.GetStream();        
            byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(textToSend);

            //---send the text---
            Console.WriteLine("Sending : " + textToSend);
			
			//buffer
			//Type: System.Byte[]
			//An array of type Byte that contains the data to write to the NetworkStream.
			//offset
			//Type: System.Int32
			//The location in buffer from which to start writing data.
			//size
			//Type: System.Int32
			//The number of bytes to write to the NetworkStream.
			
			
            nwStream.Write(bytesToSend, 0, bytesToSend.Length);

            //---read back the text---
            byte[] bytesToRead = new byte[client.ReceiveBufferSize];
            int bytesRead = nwStream.Read(bytesToRead, 0, client.ReceiveBufferSize);
            Console.WriteLine("Received : " + Encoding.ASCII.GetString(bytesToRead, 0, bytesRead));
            Console.ReadLine();
            client.Close();
        }
    }
}