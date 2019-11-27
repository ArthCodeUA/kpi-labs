package com.arthcode.labs;

public class Main {
    
    // Main function.
    public static void main(String[] args) {
        System.out.println(sequence(1));
        System.out.println(sequence(2));
        System.out.println(sequence(3));
        System.out.println(sequence(4));
    }

    // Sequence function.
    private static double sequence(int n) {
        double sum = 0;
        double x = 1;
        double y = 1;
        for (int i = 1; i <= n; i++) {
            sum += x / (1 + Math.abs(y));
            y += x;
            x *= 0.3;
        }
        return sum;
    }
}
