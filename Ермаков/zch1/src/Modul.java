import com.sun.org.apache.xpath.internal.operations.Mod;

import java.util.ArrayList;
import java.util.List;

public class Modul {
    List <Letuchka> listLetuchka;

    Modul(Letuchka...arr){
        listLetuchka = new ArrayList<Letuchka>(arr.length);
        for(Letuchka i:arr){
            listLetuchka.add(i);
        }
    }

    public int summ(){
        int summ = 0;
        for(Letuchka i: listLetuchka){
            summ += i.summ();
        }
        return summ;
    }
}
