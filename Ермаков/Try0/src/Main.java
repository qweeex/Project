import com.sun.org.apache.xpath.internal.operations.Mod;

import java.util.ArrayList;

public class Main {

    public static void main(String[] args) {

        ArrayList<Integer> sc = new ArrayList<>();
        sc.add(10);
        Student x = new Student("Vasyan",sc);
        x.addright(4);
        x.addright(6);
        System.out.println(x);

    }
}
