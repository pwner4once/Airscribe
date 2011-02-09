import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;
import java.sql.SQLException;
import java.sql.PreparedStatement;
import java.sql.Timestamp;

public class DBConnection {

	public static void main(String args[]){
		startConnection();
		newRow(1.2f, 2.3f, 3.2f, 1.2f, 4.3f, 2f);
		printDB();
		endConnection();
	}
	private static String fields[] = { "accel_x1", "accel_y1", "accel_z1",
			"accel_x2", "accel_y2", "accel_z2", "created_at" };
	private static Connection conn = null;

	public static Connection startConnection() {
		if (conn != null)
			return conn;
		
		try {
			Class.forName("com.mysql.jdbc.Driver").newInstance();

			conn = DriverManager.getConnection("jdbc:mysql://localhost/airscribe?"
							+ "user=root&password=joejoenoshow");

			if (!conn.isClosed())
				System.out.println("MySQl db: connected!");
		} catch (Exception ex) {
			System.out.println("SQLException: " + ex.getMessage());
			System.out.println("SQLState: " + ((SQLException) ex).getSQLState());
			System.out.println("VendorError: "
					+ ((SQLException) ex).getErrorCode());
		}
		return conn;
	}

	public static void endConnection() {
		if (conn != null) {
			try {
				conn.close();
			} catch (SQLException e) {
				e.printStackTrace();
			}
		}
	}

	public static void printDB() {
		if (conn == null) {
			System.out.println("Database connection not made!");
		}

		try {
			Statement stmt = conn.createStatement();
			ResultSet rs = stmt.executeQuery("Select * from sensor_data ");
			while (rs.next()) {
				for (String field : fields) {
					System.out.println(field + " : " + rs.getString(field));
				}
			}
			stmt.close();
			rs.close();
		} catch (Exception e) {
			e.printStackTrace();
		}

	}

	public static void newRow(float accel_x1, float accel_y1, float accel_z1,
			float accel_x2, float accel_y2, float accel_z2) {
		if (startConnection() == null) {
			System.out.println("Failed to initiate DB connection");
		}

		try {
			PreparedStatement ps = conn.prepareStatement("insert into airscribe.sensor_data values (default,?,?,?,?,?,?,?)");
			ps.setFloat(1, accel_x1);
			ps.setFloat(2, accel_y1);
			ps.setFloat(3, accel_z1);
			ps.setFloat(4, accel_x2);
			ps.setFloat(5, accel_y2);
			ps.setFloat(6, accel_z2);
			ps.setTimestamp(7, new Timestamp((new java.util.Date()).getTime()));
			ps.executeUpdate();
			ps.close();
		} catch (Exception e) { e.printStackTrace(); }
	}
}
