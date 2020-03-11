#include <iostream>
#include "Line.h"
#include "Text.h"

using namespace std;

void printText(Text text) {
    for (int i = 0; i < text.getLength(); ++i) {
        cout << text.getText()[i].getLine() << endl;
    }
}

int main() {
    Text text = Text();
    text.addLine(Line("Lorem ipsum dolor sit amet"));
    text.addLine(Line("consectetur adipiscing elit"));
    text.addLine(Line("Maecenas odio tellus, dictum"));
    text.addLine(Line("in mattis sed, vehicula ut ex"));
    cout << text.avgLength() << endl;
    cout << text.vowelsPercentage() << endl;
    printText(text);
    text.clearText();
    cout << endl;
    text.addLine(Line("consectetur adipiscing elit"));
    text.addLine(Line("Maecenas odio tellus, dictum"));
    printText(text);
    cout << endl;
    text.removeRegexp(Line("dictum"));
    printText(text);
    return 0;
}