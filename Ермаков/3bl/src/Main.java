public class Main {

    public static void main(String[] args) {
    Student one = new Student();
    one.marks = new int [] {3,4,5};
    one.name = "vasya";
    Student two = new Student();
    two.marks = one.marks;
    two.name = "petya";
    two.marks [0] = 5;
    System.out.println(one);
    System.out.println(two);
    }
}
