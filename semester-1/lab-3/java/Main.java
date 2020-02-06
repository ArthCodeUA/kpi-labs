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
    private static double sequence(int x) {
     final double E = 0.0001;
        double current = 1;
        double sum = current;
        for (int i = 1; current > E; i++) {
            current *= (double) x * x / (2 * i * (2 * i - 1));
            sum += i % 2 == 0 ? current : 0;
        }
        return sum;
    }
}
