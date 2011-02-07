import java.awt.Canvas;
import java.awt.Graphics;

class GCanvas extends Canvas {
  /**
   * 
   */
  private static final long serialVersionUID = 1L;
  int xpt=500, ypt=500;
  boolean clear = false;
  
  public void update(Graphics g) {
    
    if(clear){
      g.clearRect(0,0,1000,1000);
      clear = false;
      
    }else{
      try {
          g.fillOval(xpt, ypt, 10, 10); 
      } catch (Exception e) {}
    }
  }

  public void newPoint(Float xacel, Float yacel) {
    xpt = xpt + 1*Math.round(xacel);
    System.out.println("new x point: "+xpt);
    ypt = ypt + 1*Math.round(yacel);
    System.out.println("new y point: "+ypt);
    repaint();
  }

  public void clearCanvas(){
    xpt = 500;
    ypt = 500;
    clear = true;
    repaint();
  }
  
  public void paint(Graphics g) {
    update(g);
  }
}
