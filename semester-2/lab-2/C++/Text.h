#ifndef LAB_2_TEXT_H
#define LAB_2_TEXT_H

#include "Line.h"
#include <vector>

using namespace std;

class Text {
    private:
        vector<Line> text;
    public:
        int getLength();

        vector<Line> getText();

        void addLine(Line new_line);

        void removeLine(int line_index);

        void clearText();

        float avgLength();

        float vowelsPercentage();

        void removeRegexp(Line substring);
};


#endif
