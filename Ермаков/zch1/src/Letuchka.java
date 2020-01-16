import java.util.ArrayList;

public class Letuchka {
    ArrayList<Integer> grades;

    Letuchka(Integer... arr) {
        this.grades = new ArrayList<Integer>(arr.length);
        for (Integer i : arr)
            grades.add(i);
    }

    public int summ() {
        int sumGrades = 0;
        for (int i : grades)
            sumGrades += i;
        return sumGrades;
    }
}

