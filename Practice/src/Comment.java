public class Comment {
    String text;
    int rate;

    public Comment(String text, int rate) {
        this.text = text;
        this.rate = rate;
        System.out.println("(" + rate + ")" + text);
    }
}
