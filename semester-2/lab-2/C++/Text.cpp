#include <cmath>
#include <cctype>
#include "Text.h"
#include "Line.h"

using namespace std;

void Text::addLine(Line new_line) {
    text.push_back(new_line);
}

void Text::removeLine(int line_index) {
    text.erase(text.begin() + line_index);

}

int Text::getLength() {
    return text.size();
}

bool isVowel(char c) {
    return c == 'a' || c == 'e' || c == 'i' || c == 'o' ||
           c == 'u' || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U';
}

float Text::vowelsPercentage() {
    float letters = 0;
    float vowels = 0;
    for (int i = 0; i < getLength(); i++) {
        for (int k = 0; k < text[i].getLength(); k++) {
            letters++;
            char current = text[i].getLine()[k];
            if (!isalpha(current)) continue;
            if (isVowel(current))
            {
                vowels++;
            }
        }
    }
    return roundf(vowels / letters * 100);
}

float Text::avgLength() {
    auto text_len = (float) getLength();
    float line_lens = 0;
    for (int i = 0; i < getLength(); ++i) {
        line_lens += (float) text[i].getLength();
    }
    return (float) line_lens / text_len;
}

void Text::clearText() {
    text.erase(text.begin(), text.end());
}

void Text::removeRegexp(Line substring) {
    if (substring.getLength() > 0) {
        char key = substring.getLine()[0];
        for (int i = getLength()-1; i >= 0; i--) {
            for (int j = 0; j < text[i].getLength(); j++) {
                if (text[i].getLine()[j] == key && j + substring.getLength() <= text[i].getLength()) {
                    bool found = true;
                    for (int k = j; k < j+substring.getLength(); k++) {
                        if (text[i].getLine()[k] != substring.getLine()[k - j]) {
                            found = false;
                            break;
                        }
                    }
                    if (found) {
                        removeLine(i);
                        break;
                    }
                }
            }
        }
    }
}

vector<Line> Text::getText() {
    return text;
}