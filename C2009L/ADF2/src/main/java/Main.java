import database.Database;
import java.sql.*;

public class Main {
    public static void main(String [] args) {
        Database database1 = Database.getInstance();
        //chi tao ra doi tuong Database duy nhat
        //Connection connection = database.getConnection();
        Database database2 = Database.getInstance();

        System.out.println("haha");
    }
}
