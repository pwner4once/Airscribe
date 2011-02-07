import java.awt.*;
import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;
import java.net.ServerSocket;
import java.net.Socket;

import javax.swing.*;

@SuppressWarnings("serial")
class Desktop extends JFrame // create frame for canvas
{

	GCanvas canvas;

	public Desktop() // constructor
	{
		super("Airscribe Demo");
		setBounds(0, 0, 1000, 1000);// set frame
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		Container con = this.getContentPane(); // inherit main frame
		con.setBackground(Color.white); // paint background
		canvas = new GCanvas(); // create drawing canvas
		con.add(canvas);
		setVisible(true);// add to frame and show
	}

	public static void main(String args[]) {
		Desktop as = new Desktop();
		int port;
		ServerSocket server_socket;
		BufferedReader input;
		BufferedWriter output;
		try {
			port = Integer.parseInt(args[0]);
		} catch (Exception e) {
			System.out.println("port = 1500 (default)");
			port = 1500;
		}

		try {

			server_socket = new ServerSocket(port);
			System.out.println("Server waiting for client on port "
					+ server_socket.getLocalPort());

			// server infinite loop
			while (true) {
				Socket socket = server_socket.accept();
				System.out.println("New connection accepted "
						+ socket.getInetAddress() + ":" + socket.getPort());
				input = new BufferedReader(new InputStreamReader(
						socket.getInputStream()));
				output = new BufferedWriter(new OutputStreamWriter(
						socket.getOutputStream()));
				// print received data
				Enum wd = new Enum();
				boolean print = false;
				try {
					while (true) {
						char[] buf = new char[12];
						input.read(buf, 0, buf.length);
						if (buf == null) {
							return;
						}
						String str = new String(buf);
						str = str.substring(0, str.indexOf("\n"));
						String type = str.substring(0, 2);

						if (type.equals("AX")) {
							print = false;
							wd.accel_x = Float.parseFloat(str.substring(2));
						} else if (type.equals("AY")) {
							wd.accel_y = Float.parseFloat(str.substring(2));
						} else if (type.equals("AZ")) {
							wd.accel_z = Float.parseFloat(str.substring(2));
						} else if (type.equals("GX")) {
							wd.gyro_x = Integer.parseInt(str.substring(2));
						} else if (type.equals("GY")) {
							wd.gyro_y = Integer.parseInt(str.substring(2));
						} else if (type.equals("GZ")) {
							wd.gyro_z = Integer.parseInt(str.substring(2));
							print = true;
						} else if (type.equals("CL")){
							System.out.println("DETECTED CLEAR");
							as.canvas.clearCanvas();							
						}

						if (print) {
							// data ready to process
							System.out.println(wd);
							as.canvas.newPoint(wd.accel_x, wd.accel_y);
						}
						// System.out.println(str);

						// Flushing the output after the write will immediatly
						// intimate the client
						// output.write(buf,0,buf.length);
						output.flush();
					}

				} catch (IOException e) {
					System.out.println(e);
				}
				input.close();
				output.close();

				// connection closed by client
  			socket.close();
  			System.out.println("Connection closed by client");

			}
		}	catch (IOException e) {
			System.out.println(e);
		}
	}
}