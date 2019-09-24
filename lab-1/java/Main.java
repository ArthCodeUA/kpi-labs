public class Main {
    public static void main(String[] args) {
        System.out.println(aprog(1, 2, 3));
        System.out.println(aprog(5, 1, 7));
        System.out.println(aprog(512, 5423, 7642));
    }

    private static int aprog(int a, int d, int n) {
        return a + d * (n - 1);
    }
}