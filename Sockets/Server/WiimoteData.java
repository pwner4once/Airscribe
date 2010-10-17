public class WiimoteData {
    public boolean dataReady = false;
    /* acceleration data */
    public float accel_x = 0;
    public float accel_y = 0;
    public float accel_z = 0;
    
    /* gyroscope data */
    public int gyro_x = 0;
    public int gyro_y = 0;
    public int gyro_z = 0;
    
    public WiimoteData(){ }
    public WiimoteData (float ax, float ay, float az, int gx, int gy, int gz){
      this.accel_x = ax;
      this.accel_y = ay;
      this.accel_z = az;
      this.gyro_x = gx;
      this.gyro_y = gy;
      this.gyro_z = gz;
    }
    @Override
    public String toString(){
      StringBuffer sb = new StringBuffer();
      sb.append("AX: " + accel_x);
      sb.append("AX: " + accel_y);
      sb.append("AX: " + accel_z);
      sb.append("\n");
      sb.append("GX: " + accel_x);
      sb.append("GX: " + accel_y);
      sb.append("GX: " + accel_z);
      return sb.toString();
    	
    }
}
