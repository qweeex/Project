public class Comment {
    String text;
    int rate;
    Comment parent;
    int count = 0;

    public String toString(){
        if (parent != null){
            return parent + "\n" + "\t" + "(" + rate + ")" + text;
        }
        return "(" + rate + ")" + text;
    }
}
