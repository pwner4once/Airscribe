import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;
import java.sql.SQLException;
import java.sql.PreparedStatement;
import java.sql.Timestamp;

public class DBConnection {

	// DB columns
	private static String fields[] = { "accel_x", "accel_y", "accel_z",
			"gyro_x", "gyro_y", "gyro_z", "created_at" };
	private static Connection conn = null;

	public static Connection startConnection() {
		if (conn != null)
			return conn;
		
		try {
			Class.forName("com.mysql.jdbc.Driver").newInstance();

			conn = DriverManager
					.getConnection("jdbc:mysql://localhost/airscribe?"
							+ "user=root&password=joejoenoshow");

			if (!conn.isClosed())
				System.out.println("MySQl db: connected!");
		} catch (Exception ex) {
			System.out.println("SQLException: " + ex.getMessage());
			System.out
					.println("SQLState: " + ((SQLException) ex).getSQLState());
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

	public static void newRow(float accel_x, float accel_y, float accel_z,
			float gyro_x, float gyro_y, float gyro_z) {
		if (startConnection() == null) {
			System.out.println("Failed to initiate DB connection");
		}

		try {
			PreparedStatement ps = conn
					.prepareStatement("insert into airscribe.sensor_data values (default,?,?,?,?,?,?,?)");
			ps.setFloat(1, accel_x);
			ps.setFloat(2, accel_y);
			ps.setFloat(3, accel_z);
			ps.setFloat(4, gyro_x);
			ps.setFloat(5, gyro_y);
			ps.setFloat(6, gyro_z);
			ps.setTimestamp(7, new Timestamp((new java.util.Date()).getTime()));
			ps.executeUpdate();
			ps.close();
		} catch (Exception e) {
			e.printStackTrace();
		}
	}
}
