public class Enum {
    public boolean dataReady = false;
    /* acceleration data */
    public float accel_x1 = 0;
    public float accel_y1 = 0;
    public float accel_z1 = 0;
    public float accel_x2 = 0;
    public float accel_y2 = 0;
    public float accel_z2 = 0;
    
    public Enum(){ }
    public Enum (float ax, float ay, float az, int gx, int gy, int gz){
      this.accel_x1 = ax;
      this.accel_y1 = ay;
      this.accel_z1 = az;
      this.accel_x2 = gx;
      this.accel_y2 = gy;
      this.accel_z2 = gz;
    }
    @Override
    public String toString(){
      StringBuffer sb = new StringBuffer();
      sb.append("AX: " + accel_x1);
      sb.append("AX: " + accel_y1);
      sb.append("AX: " + accel_z1);
      sb.append("\n");
      sb.append("GX: " + accel_x2);
      sb.append("GX: " + accel_y2);
      sb.append("GX: " + accel_z2);
      return sb.toString();
    	
    }
}
