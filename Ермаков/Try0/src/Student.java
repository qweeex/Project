import java.util.ArrayList;

public class Student {
        String name;
        ArrayList<Integer> scores = new ArrayList<>();


        Student(String name){
            this.name = name;
        }

        public void addright(int x){
            if (x>2&&x<6){
                this.scores.add(x);
            }
        }

        Student (String name, ArrayList<Integer> scores){
            this.name = name;
            for (Integer g: scores){
                this.scores.add(g);
            }
        }
        Student (String name, int max, boolean check){
            this.name = name;
            for (int i = 0; i <= max; i++){
                if (check == true){
                    if (i>2&&i<6){
                        this.scores.add(i);
                    }
                }
                else
                this.scores.add(i);
            }
        }
    Student (String name, int max){
        this.name = name;
        for (int i = 0; i <= max; i++){
            this.scores.add(i);
        }
    }

        public String toString(){
            return this.name + this.scores.toString();
        }
    }
