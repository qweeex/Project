import java.util.ArrayList;

public class Combo {

    ArrayList<Sound> combo = new ArrayList<>();

    public void addhit(Sound a){
        combo.add(a);
    }

    public void perform(){
        for (Sound g: combo){
            g.hit();
        }
    }

}
