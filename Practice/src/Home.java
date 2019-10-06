public class Home {
    int floors;

    public Home(int floors) {
        this.floors = floors;
        int count;
        int buffer = 0;
        if (floors > 20) {
            buffer = floors / 10;
            buffer *= 10;
        }

        count = floors - buffer;
        if (count == 1)
            System.out.println("Дом с " + floors + " этажом");
        else
            System.out.println("Дом с " + floors + " этажами");
    }
}

