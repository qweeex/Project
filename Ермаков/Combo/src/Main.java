public class Main {

    public static void main(String[] args) {

        Boom one = new Boom();
        Bah two = new Bah();
        Kiya three = new Kiya();
        Combo four = new Combo();
        four.addhit(one);
        four.addhit(two);
        four.addhit(three);
        four.perform();
    }
}
