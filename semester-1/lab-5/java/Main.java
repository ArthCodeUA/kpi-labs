package com.arthcode.labs;

import java.util.ArrayList;
import java.util.List;

public class Main {
    
    // Main function.
    public static void main(String[] args) {
        System.out.println(task(153, 15).toString());
    }

    // Function for returning the list of divisors of number p, that in the same time are coprime with number q.
    private static List task(int p, int q) {
        ArrayList<Integer> arr = new ArrayList<>();
        for (int i = 1; i <= p; i++) {
            if(p % i == 0) {
                if(areCoprime(i, q)) {
                    arr.add(i);
                }
            }
        }
        return arr;
    }

    // Checking if numbers are coprime, i.e their GCD (greatest common divisor) is 1.
    private static boolean areCoprime(int a, int b) {
        a = Math.abs(a);
        b = Math.abs(b);
        while(b > 0) {
            int t = b;
            b = a % b;
            a = t;
        }
        // Here a variable is GCD, calculated by Euclidean Algorithm, which is represented above in while method.
        return a == 1;
    }
}
