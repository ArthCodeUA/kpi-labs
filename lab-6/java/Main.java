package com.arthcode.labs;

public class Main {
    
    // Main function.
    public static void main(String[] args) {
        System.out.println(f(12, 1));
    }

    // Function h(a,b) is a function, that is being used in function F.
    private static double h(double a, double b) {
        return (a / (1 + Math.pow(b, 2)) + (b / (1 + Math.pow(a, 2))) - Math.pow(a - b, 3));
    }

    // Function F, that is solution of the task. Instead of h(1,1) there is just 1 in the end of function.
    // This is because of h(1,1) is a constant value and it equals to 1.
    private static double f(double s, double t) {
        return h(s, t) + Math.max(Math.pow(h(s - t, s * t), 2), Math.pow(h(s - t, s + t), 4) + 1);
    }
}
