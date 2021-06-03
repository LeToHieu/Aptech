import models.Food;

import java.text.SimpleDateFormat;

public class App {
    public static void main(String [] args) {
        System.out.println("hello");
        //Thu tao ra cac doi tuong food
        //string: 32/12/2021 => Date
        //new SimpleDateFormat("dd/MM/yyyy").parse("31/12/1998")
        Food food1 = new Food(1, "sushi", 12.3f,
                Helper.convertStringToDate("31/05/2021"),
                Helper.convertStringToDate("01/06/2021"));
        Food food2 = new Food(1, null, -123.4f,
                Helper.convertStringToDate("31/05/2021"),
                Helper.convertStringToDate("29/05/2021"));
        System.out.println("haha");
    }
}
