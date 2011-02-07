// default port is 1500.
// connection to be closed by client.
// this server handles only 1 connection.

import java.net.*;
import java.io.*;
public class Server {

  public static void main(String args[]) {

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
        System.out.println("New connection accepted ");
        System.out.println(socket.getInetAddress());
        System.out.println(":");
        System.out.println(socket.getPort());
        
        input = new BufferedReader(new InputStreamReader(socket.getInputStream()));
        output = new BufferedWriter(new OutputStreamWriter(socket.getOutputStream()));

        // print received data
        Enum wd = new Enum();
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
              System.out.println(wd);
            }

            output.flush();
          }

        } catch (IOException e) { e.printStackTrace();}
        
        input.close();
        output.close();

        // connection closed by client
        try {
          socket.close();
          System.out.println("Connection closed by client");
        } catch (IOException e) {
          System.out.println(e);
        }
      }
    } catch (IOException e) {
      e.printStackTrace();
    }
  }
}
