#ifndef LAB_2_TEXT_H
#define LAB_2_TEXT_H

#include "Line.h"

using namespace std;

class Text {
    private:
        Line* text;
        int length;
    public:
        Text();

        int getLength();

        Line* getText();

        void addLine(Line new_line);

        void removeLine(int line_index);

        void clearText();

        float avgLength();

        float vowelsPercentage();

        void removeRegexp(Line substring);
};


#endif
