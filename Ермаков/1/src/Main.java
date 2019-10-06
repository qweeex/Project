public class Main {

    public static void main(String[] args) {
        System.out.println(Short.MIN_VALUE);
        System.out.println(Short.MAX_VALUE);
        int res = 0;
        for (int i = 0; i < args.length; i++) {
            res += Integer.parseInt(args[i]);
        }
        System.out.println(res);
        Integer x1 = new Integer(10);
        Integer x2 = 10;
        Integer x3 = Integer.valueOf(10);
        int x4 = x1;
        System.out.println(x1 == x2);//false
        System.out.println(x1 == x4);//true
        System.out.println(x2 == x3);//true dz - что такое valueOf и как оно работает?
        Integer zhopa1 = 500;
        System.out.println(Integer.valueOf(zhopa1));
        Integer zhopa2 = 500;
        System.out.println(Integer.valueOf(zhopa2));
        System.out.println(zhopa1 == zhopa2);//false
        System.out.println(Integer.valueOf(zhopa1)==Integer.valueOf(zhopa2));//false
        int z = zhopa1 - zhopa2;
        System.out.println(z);
        Integer x6 = 50;
        Integer x7 = 50;
        System.out.println(x6 == x7);//true. Watafack?
        int y = 500;
        int y1 = 500;
        System.out.println(y == y1);//true
        int y2 = 50;
        int y3 = 50;
        System.out.println(y2 == y3);//true
    }
}
