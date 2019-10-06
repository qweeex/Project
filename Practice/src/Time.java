public class Time {
    int sec;

    public Time(int sec) {
        this.sec = sec;
        int hours;
        int minuts;
        int balance = 0;

        if (sec >= 3600) {
            hours = sec / 3600;
            if (hours >= 24) {
                hours -= 24;
                balance = 24;
            }
        } else hours = 0;

        if (sec >= 60) {
            minuts = sec / 60;
            if (hours > 0) {
                minuts -= (hours + balance) * 60;
            }
        } else minuts = 0;

        if (minuts > 0) {
            sec -= minuts * 60;
            if (hours > 0)
                sec -= (hours + balance) * 3600;
        }

        System.out.println(hours + ":" + minuts + ":" + sec);
    }
}
