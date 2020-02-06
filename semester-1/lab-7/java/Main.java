package com.arthcode.labs;

import java.util.ArrayList;
import java.util.Arrays;

public class Main {

    // Main function.
    public static void main(String[] args) {
        ArrayList<Integer> array = new ArrayList<>(Arrays.asList(1,2,3,4,6,1,5,2,5,6,-1,-3,-6,-6,-7,-1,-8,-2,-8));
        System.out.println(newArray(array, avgNegative(array)));
    }

    // Function newArray(a,b) is a function, that is being used to get new array, containing
    // all the even numbers multiplied by multiplier m
    private static ArrayList newArray(ArrayList<Integer> arr, int m) {
        ArrayList<Integer> newArr = new ArrayList<>();
        for (int k = 0; k < arr.size(); k++) {
            newArr.add(isEven(k) ? arr.get(k) * m : arr.get(k));
        }
        return newArr;
    }

    // Function avgNegative, that returns average of negative numbers in array
    private static int avgNegative(ArrayList<Integer> arr) {
        ArrayList<Integer> negativeArray = new ArrayList<>();
        for (int integer : arr) {
            if (integer < 0) {
                negativeArray.add(integer);
            }
        }
        return Math.abs(addition(negativeArray) / negativeArray.size());
    }

    // Function isEven check, if number is even
    private static boolean isEven(int n) {
        return n % 2 == 0;
    }

    // Sum of all array elements
    private static int addition(ArrayList<Integer> arr) {
        int sum = 0;
        for (int integer : arr) {
            sum += integer;
        }
        return sum;
    }
}
