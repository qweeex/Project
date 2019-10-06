public class Human {
    String name;
    int height;

    public Human(String name, int height) {
        this.name = name;
        this.height = height;
        if (height < 160)
            System.out.println(this.name + " маленький человек");
        else {
            if (height > 180)
                System.out.println(this.name + " высокий человек");
            else
                System.out.println(this.name + " средний человек");
        }
    }
}
