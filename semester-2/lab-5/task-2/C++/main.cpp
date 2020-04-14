#include <iostream>
#include "LetterString.h"
#include "NumberString.h"

using namespace std;

int main() {
    char* letters = (char*) "cdasdasa";
    char* numbers = (char*) "5812845";
    LetterString letterString = LetterString(letters);
    NumberString numberString = NumberString(numbers);
    numberString.RemoveCharacter('5');
    letterString.RemoveCharacter('a');
    cout << letterString.GetValue() << endl;
    cout << numberString.GetValue() << endl;
    return 0;
}