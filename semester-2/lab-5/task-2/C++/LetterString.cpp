//
// Created by Arthur Ladchenko on 15.04.2020.
//

#include "LetterString.h"
#include <string>

LetterString::LetterString(char *value) : BaseString(value) {
    if (!this->isLetterString(value))
    {
        throw std::runtime_error("String should only contain letters!");
    }
}

void LetterString::RemoveCharacter(char c = 'a') {
    BaseString::RemoveCharacter(c);
}

bool LetterString::isLetterString(char *value) {
    int length = strlen(value);
    int letters = 0;
    for (int i = 0; i < length; ++i) {
        if(isalpha(value[i])) {
            letters++;
        }
    }
    return length == letters;
}
