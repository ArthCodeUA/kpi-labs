#include "functions.h"

bool equality(int a, int b) {
    return !(a^b);
}

void increment(int a, int &x) {
    x = -~a;
}