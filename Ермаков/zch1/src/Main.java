public class Main {

    public static void main(String[] args) {
        Letuchka one = new Letuchka(3,4,5);
        Letuchka two = new Letuchka(4,2);
        Modul first = new Modul(one,two);
        Letuchka three = new Letuchka(5,3);
        Letuchka four = new Letuchka(3,4);
        Modul second = new Modul (three,four);

        Student me = new Student("Vlad",first,second);

        System.out.println(me.name+"\n"+me.summ());
    }
}
