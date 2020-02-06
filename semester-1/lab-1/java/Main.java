public class Main {
    public static void main(String[] args) {
        System.out.println(aprog(1, 2, 3));
        System.out.println(aprog(5, 1, 7));
        System.out.println(aprog(512, 5423, 7642));
    }

    private static double aprog(double a, double d, double n) {
        return a + d * (n - 1);
    }
}