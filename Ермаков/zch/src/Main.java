public class Main {

    public static void main(String[] args) {
        CarateKid ent = new CarateKid();
        Combo combo1 = new Combo(ent);
        Punch action1 = new Punch();
        Kick action2 = new Kick();
        Hook action3 = new Hook();

        combo1.add(action1);
        combo1.add(action2);
        combo1.add(action3);

        combo1.perform();
    }
}
