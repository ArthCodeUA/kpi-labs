#include <iostream>
#include "functions.h"

using namespace std;

int main() {
    // Testing Increment Function
    int x = 0;
    increment(-43, x);
    cout << x << endl;
    increment(75, x);
    cout << x << endl;
    increment(63, x);
    cout << x << endl;

    cout << endl;

    // Testing Equality Function
    cout << (equality(48, 48) ? "True" : "False") << endl;
    cout << (equality(69, 78) ? "True" : "False") << endl;
    cout << (equality(24, 25) ? "True" : "False") << endl;

    return 0;
}