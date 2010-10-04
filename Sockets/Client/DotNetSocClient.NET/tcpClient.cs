// default port is 1500
using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
public class StateObject 
{
	// Client socket.
	public Socket workSocket = null;
	// Size of receive buffer.
	public const int BufferSize = 256;
	// Receive buffer.
	public byte[] buffer = new byte[BufferSize];
	// Received data string.
	public StringBuilder sb = new StringBuilder();
}

public class tcpClient
{
	static ManualResetEvent receiveDone = new ManualResetEvent(false);
    static System.Net.Sockets.Socket socket = null;
    static System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();

    //[STAThread]
    //public static void  Main(System.String[] args)
    //{
    //    initConnection(1500);
    //}

    [STAThread]
    public static void initConnection()
    {
        initConnection(1500);
    }
    [STAThread]
    public static void initConnection(int portNumber)
    {
        System.String server = "nt126101";

        System.String lineToBeSent;
        System.IO.StreamReader input;
        System.IO.StreamWriter output;
        int ERROR = 1;

        System.Console.Out.WriteLine("server port = 1500 (default)");

        try
        {
            //UPGRADE_TODO: Expected value of parameters of constructor 'java.io.BufferedReader.BufferedReader' are different in the equivalent in .NET. 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="jlca1092"'
            //UPGRADE_ISSUE: 'java.lang.System.in' was converted to 'System.Console.In' which is not valid in this expression. 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="jlca1109"'
            //			input = new System.IO.StreamReader(new System.IO.StreamReader(System.Console.In).BaseStream, System.Text.Encoding.UTF7);
            //			System.IO.StreamWriter temp_writer;
            //			temp_writer = new System.IO.StreamWriter((System.IO.Stream) socket.GetStream());
            //			temp_writer.AutoFlush = true;
            //			output = temp_writer;

            // get user input and transmit it to server

            socket = new System.Net.Sockets.Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            System.Net.IPAddress ipAdd = System.Net.IPAddress.Parse("127.0.0.1");
            System.Net.IPEndPoint remoteEP = new System.Net.IPEndPoint(ipAdd, portNumber);

            socket.Connect(remoteEP);
            //Async Read form the server side!

            Receive(socket);
            //new System.Net.Sockets.TcpClient(server, port);
            while (true)
            {
                lineToBeSent = System.Console.ReadLine();

                // stop if input line is "."
                if (lineToBeSent.Equals("."))
                {
                    socket.Close();
                    break;
                }
                lineToBeSent += "\n";
                //output.WriteLine(lineToBeSent);\
                //System.Net.Sockets.NetworkStream tempstream = socket.GetStream();
                Send(lineToBeSent);
            }
            


            byte[] Serbyte = new byte[30];
            //			socket.Receive(Serbyte,0,20,System.Net.Sockets.SocketFlags.None);
            //			System.Console.WriteLine("Message from server \n" + encoding.GetString(Serbyte));

            //socket.Close();


        }
        catch (System.IO.IOException e)
        {
            System.Console.Out.WriteLine(e);
        }	
    }
    [STAThread]
    public static void CloseConnection()
    {
        socket.Close();
    }
    [STAThread]
    public static void Send(System.String lineToBeSent)
    {
        socket.Send(encoding.GetBytes(lineToBeSent));
    }
    [STAThread]
    public static void Receive(Socket client) 
	{
		try 
		{
			// Create the state object.
			StateObject state = new StateObject();
			state.workSocket = client;

			// Begin receiving the data from the remote device.
			client.BeginReceive( state.buffer, 0, StateObject.BufferSize, 0,
				new AsyncCallback(ReceiveCallback), state);
			
		} 
		catch (Exception e) 
		{
			Console.WriteLine(e.ToString());
		}
	}

	static string response = "";
    [STAThread]
    public static void ReceiveCallback(IAsyncResult ar) 
	{
		try 
		{
			// Retrieve the state object and the client socket 
			// from the asynchronous state object.
		
			StateObject state = (StateObject) ar.AsyncState;
			Socket client = state.workSocket;
			// Read data from the remote device.
			int bytesRead = client.EndReceive(ar);
			if (bytesRead > 0) 
			{
				// There might be more data, so store the data received so far.
				state.sb.Append(Encoding.ASCII.GetString(state.buffer,0,bytesRead));
				//  Get the rest of the data.
				if (state.sb.Length > 1) 
				{
					response = Encoding.ASCII.GetString(state.buffer,0,bytesRead).ToString();
                    response = response.Substring(0, response.IndexOf("\n")+1);
					Console.WriteLine(response);
				}
				client.BeginReceive(state.buffer,0,StateObject.BufferSize,0,
					new AsyncCallback(ReceiveCallback), state);
			} 
			else 
			{
				// All the data has arrived; put it in response.
				if (state.sb.Length > 1) 
				{
					response = state.sb.ToString();
					Console.WriteLine(response);
				}
				// Signal that all bytes have been received.
				
				//receiveDone.Set();
				
			}
		} 
		catch (Exception e) 
		{
			Console.WriteLine(e.ToString());
		}
	}
}