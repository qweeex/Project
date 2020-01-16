import com.sun.org.apache.xpath.internal.operations.Mod;

import java.util.ArrayList;
import java.util.List;

public class Student {
    String name;
    List<Modul> semestr;

    Student(String name, Modul... arr) {
        this.name = name;
        semestr = new ArrayList<Modul>(arr.length);

        for (Modul i : arr)
            semestr.add(i);
    }

    public int summ() {
        int summ = 0;
        for (Modul i : semestr)
            summ += i.summ();
        return summ;
    }
}
