#include <iostream>

using namespace std;

int GetFirstCharIndex(char symbol, string str);

int main() {
    int (*GetFirstCharIndexPointer)(char, string);
    GetFirstCharIndexPointer = GetFirstCharIndex;
    std::cout << GetFirstCharIndexPointer('s', "wassup") << std::endl;
    return 0;
}

int GetFirstCharIndex(char symbol, string str) {
    for (int i = 0; i < str.length(); i++) {
        if (str.at(i) == symbol) {
            return i;
        }
    }
    return -1;
}
