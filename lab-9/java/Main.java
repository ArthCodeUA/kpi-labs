package com.arthcode.labs;

public class Main {

    // Main function.
    public static void main(String[] args) {
        System.out.println(filterString("hello hbo friend halo wow cool of haslo great britain very well", 'h', 'o'));
    }

    // String filter function.
    private static String filterString(String s, char sl, char el) {
        StringBuilder sb = new StringBuilder();
        for (String s1 : s.split(" ")) {
            if(s1.charAt(0) == sl && s1.charAt(s1.length() - 1) == el) {
                sb.append(s1).append(" ");
            }
        }
        return sb.toString();
    }
}
