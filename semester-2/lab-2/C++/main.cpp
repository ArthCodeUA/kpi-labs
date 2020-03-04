#include <iostream>
#include "Line.h"
#include "Text.h"

using namespace std;

void printText(Text text) {
    for (int i = 0; i < text.getText().size(); ++i) {
        cout << text.getText()[i].getLine() << endl;
    }
}

int main() {
    Text text = Text();
    text.addLine(Line("Lorem ipsum dolor sit amet"));
    text.addLine(Line("consectetur adipiscing elit"));
    text.addLine(Line("Maecenas odio tellus, dictum"));
    text.addLine(Line("in mattis sed, vehicula ut ex"));
    printText(text);
    text.clearText();
    text.addLine(Line("ez4me"));
    printText(text);
    return 0;
}