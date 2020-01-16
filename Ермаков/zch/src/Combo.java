import java.util.ArrayList;
import java.util.List;

    public class Combo {
        List<Fight> punches = new ArrayList<>();
        CarateKid man;

        Combo(CarateKid man){
            this.man = man;
        }

        public void add(Fight strike){
            punches.add(strike);
        }

        public void perform(){
            for(Fight panch: punches){
                panch.getResult(man);
            }
        }
        }
