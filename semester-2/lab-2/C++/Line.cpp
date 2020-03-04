#include <cstring>
#include "Line.h"

using namespace std;

Line::Line(char* line) {
    this -> line = line;
}

int Line::getLength() {
    return strlen(line);
}

char* Line::getLine() {
    return line;
}