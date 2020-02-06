public class Main {

    public static void main(String[] args) {
        System.out.println(isInArea(-1, 1));
        System.out.println(isInArea(1, 0.5));
    }

    private static boolean isInTriangle(double x, double y, Triangle triangle) {
        double a = (triangle.getA().getX() - x) * (triangle.getB().getY() - triangle.getA().getY()) -
                (triangle.getB().getX() - triangle.getA().getX()) * (triangle.getA().getY() - y);
        double b = (triangle.getB().getX() - x) * (triangle.getC().getY() - triangle.getB().getY()) -
                (triangle.getC().getX() - triangle.getB().getX()) * (triangle.getB().getY() - y);
        double c = (triangle.getC().getX() - x) * (triangle.getA().getY() - triangle.getC().getY()) -
                (triangle.getA().getX() - triangle.getC().getX()) * (triangle.getC().getY() - y);
        return (a >= 0 && b >= 0 && c >= 0) || (a <= 0 && b <= 0 && c <= 0);
    }

    private static boolean isInCircle(double x, double y, Circle circle) {
        return Math.pow(x - circle.getCenter().getX(), 2) + Math.pow(y - circle.getCenter().getY(), 2) <= Math.pow(circle.getRadius(), 2);
    }

    private static boolean isInArea(double x, double y) {
        Circle circle = new Circle(new Point(1, 0), 2);
        Triangle triangle = new Triangle(new Point(1, 2), new Point(3, 0), new Point(1, -2));
        return (isInCircle(x, y, circle) && x <= 1 && x >= -1) || (isInTriangle(x, y, triangle));
    }
}
