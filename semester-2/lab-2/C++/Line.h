#ifndef LINE_H
#define LINE_H

#include <string>
#include <cstring>
using namespace std;

class Line {
private:
    char* line;
public:
    Line() = default;
    explicit Line(char* Line);
    int getLength();
    char* getLine();
};

#endif