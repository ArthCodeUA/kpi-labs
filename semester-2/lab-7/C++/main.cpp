#include <iostream>
#include "ShortList.h"

int main() {
    ShortList shortList = ShortList();
    shortList.insert(1);
    shortList.insert(5);
    shortList.insert(2);
    shortList.insert(6);
    shortList.insert(3);
    shortList.insert(7);
    shortList.display();
    cout << shortList.multiplesOfThree() << endl;
    shortList.removeAboveAverage();
    shortList.display();
    return 0;
}
