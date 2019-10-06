import java.awt.*;

public class Main {
    public static void main(String[] args) {
        Point one = new Point(24, 20);
        Point two = new Point(12, 0);
        Point three = new Point(9, 21);
        Comment first = new Comment("dwarfs", 15);
        Comment second = new Comment("elves", 10);
        Comment third = new Comment("dragon", 1);
        Human cleo = new Human("Клеопатра", 152);
        Human push = new Human("Пушкин", 167);
        Human vova = new Human("Владимир", 189);
        Time ten = new Time(10);
        Time tenth = new Time(10000);
        Time hundth = new Time(100000);
        Home little = new Home(1);
        Home middle = new Home(5);
        Home big = new Home(23);
    }
}