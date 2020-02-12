#include <iostream>

using namespace std;

bool equality(int a, int b) {
    return !(a^b);
}

int increment(int a) {
    return -~a;
}

int main() {
    // Testing Increment Function
    cout << increment(-43) << endl;
    cout << increment(75) << endl;
    cout << increment(63) << endl;

    cout << endl;

    // Testing Equality Function
    cout << (equality(48, 48) ? "True" : "False") << endl;
    cout << (equality(69, 78) ? "True" : "False") << endl;
    cout << (equality(24, 25) ? "True" : "False") << endl;

    return 0;
}