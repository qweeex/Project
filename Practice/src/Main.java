import java.awt.*;

public class Main {
    public static void main(String[] args) {
        Point one = new Point(24, 20);
        System.out.println(one);
        Point two = new Point(12, 0);
        System.out.println(two);
        Point three = new Point(9, 21);
        System.out.println(three);
        Comment first = new Comment();//("dwarfs", 15)
        first.rate = 15;
        first.text = "dwarfs";
        System.out.println(first);
        Comment second = new Comment();//("elves", 10)
        second.rate = 10;
        second.text = "elves";
        Comment third = new Comment();//("dragon", 1);
        third.rate = 1;
        third.text = "dragon";
        Name cleopatra = new Name();
        Name pushkin = new Name();
        Name mayak = new Name();
        cleopatra.fName = "Клеопатра";
        pushkin.fName = "Александр";
        pushkin.lName = "Пушкин";
        pushkin.pName = "Сергеевич";
        mayak.fName = "Владимир";
        mayak.lName = "Маяковский";
        System.out.println(cleopatra);
        System.out.println(pushkin);
        System.out.println(mayak);
        Time ten = new Time(10);
        Time tenth = new Time(10000);
        Time hundth = new Time(100000);
        Home little = new Home(1);
        Home middle = new Home(5);
        Home big = new Home(23);
        Line line_1 = new Line(1, 3, 23, 8);
        Line line_2 = new Line(5, 10, 25, 10);
        Line line_3 = new Line();
        line_3.begin_Point = line_1.begin_Point;
        line_3.end_Point = line_2.end_Point;
        line_1.begin_Point.x = 10;
        line_2.end_Point.y = 20;
        System.out.println(line_3);
        Point begin_Point = new Point();
        line_3.begin_Point = begin_Point;
        line_1.begin_Point.x = 55;
        System.out.println(line_1);
        System.out.println(line_2);
        System.out.println(line_3);
        Human cleo = new Human();
        Human push = new Human();
        Human vladimir = new Human();
        cleo.name = cleopatra;
        cleo.height = 152;
        push.name = pushkin;
        push.height = 167;
        vladimir.name = mayak;
        vladimir.height = 189;
        System.out.println(cleo);
        System.out.println(push);
        System.out.println(vladimir);
        Human ivan = new Human();
        Name iv = new Name();
        iv.fName = "Иван";
        iv.lName = "Чудов";
        Human petr = new Human();
        Name pe = new Name();
        pe.fName = "Петр";
        pe.lName = "Чудов";
        Human boris = new Human();
        Name bo = new Name();
        bo.fName = "Борис";
        ivan.name = iv;
        ivan.height = 175;
        petr.father = ivan;
        petr.name = pe;
        petr.height = 167;
        boris.name = bo;
        boris.height = 183;
        boris.father = petr;
        System.out.println(ivan);
        System.out.println(petr);
        System.out.println(boris);
        Department IT = new Department();
        Employee goat = new Employee();
        Name go = new Name();
        go.lName = "Козлов";
        goat.name = go;
        goat.department = IT;
        IT.title = "it";
        IT.chief = goat;
        Employee petrov = new Employee();
        Employee sidorov = new Employee();
        Name pet = new Name();
        Name sid = new Name();
        pet.lName = "Петров";
        sid.lName = "Сидоров";
        petrov.name = pet;
        sidorov.name = sid;
        petrov.department = IT;
        sidorov.department = IT;
        System.out.println(petrov);
        System.out.println(sidorov);
        System.out.println(goat);
        Comment fourth = new Comment();
        fourth.rate = 25;
        fourth.text = "people";
        fourth.parent = first;
        System.out.println(fourth);
        Comment fifth = new Comment();
        fifth.rate = 50;
        fifth.text = "halflings";
        fifth.parent = fourth;
        System.out.println(fifth);

    }
}