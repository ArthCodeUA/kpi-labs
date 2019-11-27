package com.arthcode.labs;

import java.util.ArrayList;

public class Main {

    // Main function.
    public static void main(String[] args) {
        matrixPrint(matrix(1,2,3,4,5,6,7,8,9));
    }

    private static ArrayList<ArrayList<Integer>> matrix(int... nums) {
        ArrayList<ArrayList<Integer>> mx = new ArrayList<>();
        ArrayList<Integer> n = new ArrayList<>();
        for (int num : nums) {
            n.add(num);
        }
        for(int q = 0; q < nums.length; q++) {
            ArrayList<Integer> at = new ArrayList<>(n);
            mx.add(at);
            int t = n.get(0);
            n.remove(0);
            n.add(t);
        }
        return mx;
    }

    private static void matrixPrint(ArrayList<ArrayList<Integer>> matrix) {
        for (ArrayList<Integer> integers : matrix) {
            for (Integer integer : integers) {
                System.out.print(integer + " ");
            }
            System.out.println();
        }
    }
}
