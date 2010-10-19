import java.awt.*; 
import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;
import java.net.ServerSocket;
import java.net.Socket;

import javax.swing.*;
class Airscribe extends JFrame // create frame for canvas
{
	
	GCanvas canvas;
	
  public Airscribe() // constructor
  {
    super("Airscribe Demo");setBounds(0,0,1000,1000);// set frame
    setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    Container con=this.getContentPane(); // inherit main frame
    con.setBackground(Color.white);        // paint background
    canvas=new GCanvas();     // create drawing canvas
    con.add(canvas); setVisible(true);// add to frame and show
  }

	public static void main(String args[]) {
	Airscribe as = new Airscribe();
	int port;
	ServerSocket server_socket;
	BufferedReader input;
	BufferedWriter output;
	try { 
	    port = Integer.parseInt(args[0]);
	}
	catch (Exception e) {
	    System.out.println("port = 1500 (default)");
	    port = 1500;
	}

	try {
	    
	    server_socket = new ServerSocket(port);
	    System.out.println("Server waiting for client on port " +
			       server_socket.getLocalPort());
	    
	    // server infinite loop
	    while(true) {
	    	Socket socket = server_socket.accept();
	    	System.out.println("New connection accepted " +
				   socket.getInetAddress() +
				   ":" + socket.getPort());
			input = new BufferedReader(new InputStreamReader(socket.getInputStream()));
			output = new BufferedWriter(new OutputStreamWriter(socket.getOutputStream()));
		// print received data
		try {

		    while(true) {
	            char[] buf = new char[20];

     input.read(buf,0,20);
     if (buf==null) {
  	   return;
     }
     String str = new String(buf);
     str = str.substring(0, str.indexOf("\n"));
      System.out.println(str);
      as.canvas.newPoint(str);
    // input.close();


     // output.flush();
//      for(int i=0;i<15;i++)
      {
      //Flushing the output after the write will immediatly intimate the client
          output.write(buf,0,20);
          output.flush();
      }
        //output.write(buf);
      //output.flush();


		    }
		}
		catch (IOException e) {
		    System.out.println(e);
		}


		// connection closed by client
		try {
		    socket.close();
		    System.out.println("Connection closed by client");
		}
		catch (IOException e) {
		    System.out.println(e);
		}
		
	    }
	    
	    
	}
	
	catch (IOException e) {
	    System.out.println(e);
	}
  }
}
class GCanvas extends Canvas
{
  String tString="";
  public void update( Graphics g ) {
	  if(tString.toLowerCase().equals("clear")){
		  g.clearRect(0, 0, 1000, 1000);
	  }else{	  
		  try{
		     String [] temp = tString.split(" ");
		     g.fillOval((Integer.parseInt(temp[0])-5), (Integer.parseInt(temp[1])-5), 10, 10);
		  }catch(Exception e){}
	  }
  }
  public void newPoint(String str){
	  tString = str;
	  repaint();
  }
  
  public void paint( Graphics g ) {
     update( g );
  }
}
//import java.applet.*;
//import java.awt.*;
//import java.awt.event.*;
//import java.net.*;
//import java.io.*;
//					
//public class Airscribe extends Applet implements MouseMotionListener, ActionListener, TextListener  {
//
//   int width, height;
//   Image backbuffer;
//   Graphics backg;
//   TextField nameField; 
//   
//   
//   public void init() {
//	  try{
//	  setSize(1000, 1000);
//      width = getSize().width;
//      height = getSize().height;
//
//      backbuffer = createImage(width, height );
//      backg = backbuffer.getGraphics();
//      backg.setColor( Color.white );
//      backg.fillRect( 0, 0, width, height );
//      backg.setColor( Color.black );
//      
//      setLayout(new BorderLayout()); 	
//      
//      nameField = new TextField("Sample",25);
//      add(nameField,"East"); 
//      
//      nameField.addTextListener(this);    
//      addMouseMotionListener( this );
//	  }catch(Exception e){
//	  }
//   }
//   
//
//   public void mouseMoved( MouseEvent e ) { }
//   public void mouseDragged( MouseEvent e ) {
//      int x = e.getX();
//      int y = e.getY();
//      backg.fillOval(x-5,y-5,10,10);
//      repaint();
//      e.consume();
//   }
//
//   public void update( Graphics g ) {
//	  try{
//      g.drawImage( backbuffer, 0, 0, this );
//      g.drawString(nameField.getText(),20,100); 
//      String [] temp = nameField.getText().split(" ");
//      backg.fillOval((Integer.parseInt(temp[0])-5), (Integer.parseInt(temp[1])-5), 10, 10);
//      //g.drawLine(Integer.parseInt(temp[0]),Integer.parseInt(temp[1]), Integer.parseInt(temp[2]), Integer.parseInt(temp[3]));
//	  }catch(Exception e){}
//   }
//
//   public void paint( Graphics g ) {
//      update( g );
//      g.drawString(nameField.getText(),20,100); 
//   }
//
//   public void actionPerformed(ActionEvent evt)  
//   { 
//	   repaint();
//   }
//
//
//	public void textValueChanged(TextEvent e) {
//		repaint();
//		
//	}
//   
//	public static void main(String args[]) {
//		
//		int port;
//		ServerSocket server_socket;
//		BufferedReader input;
//		BufferedWriter output;
//		try { 
//		    port = Integer.parseInt(args[0]);
//		}
//		catch (Exception e) {
//		    System.out.println("port = 1500 (default)");
//		    g.drawString("port = 1500 (default)",20,100);
//		    port = 1500;
//		}
//
//		try {
//		    
//		    server_socket = new ServerSocket(port);
//		    System.out.println("Server waiting for client on port " +
//				       server_socket.getLocalPort());
//		    
//		    // server infinite loop
//		    while(true) {
//		    	Socket socket = server_socket.accept();
//		    	System.out.println("New connection accepted " +
//					   socket.getInetAddress() +
//					   ":" + socket.getPort());
//				input = new BufferedReader(new InputStreamReader(socket.getInputStream()));
//				output = new BufferedWriter(new OutputStreamWriter(socket.getOutputStream()));
//			// print received data
//			try {
//
//			    while(true) {
//		            char[] buf = new char[20];
//
//	       input.read(buf,0,20);
//	       if (buf==null) {
//	    	   return;
//	       }
//	       String str = new String(buf);
//	       str = str.substring(0, str.indexOf("\n"));
//	        System.out.println(str);
//	      // input.close();
//
//
//	       // output.flush();
////	        for(int i=0;i<15;i++)
//	        {
//	        //Flushing the output after the write will immediatly intimate the client
//	            output.write(buf,0,20);
//	            output.flush();
//	        }
//	          //output.write(buf);
//	        //output.flush();
//
//
//			    }
//			}
//			catch (IOException e) {
//			    System.out.println(e);
//			}
//
//
//			// connection closed by client
//			try {
//			    socket.close();
//			    System.out.println("Connection closed by client");
//			}
//			catch (IOException e) {
//			    System.out.println(e);
//			}
//			
//		    }
//		    
//		    
//		}
//		
//		catch (IOException e) {
//		    System.out.println(e);
//		}
//	    }
//	
//}
