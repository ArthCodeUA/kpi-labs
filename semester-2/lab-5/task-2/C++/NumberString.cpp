//
// Created by Arthur Ladchenko on 15.04.2020.
//

#include "NumberString.h"
#include <string>

NumberString::NumberString(char *value) : BaseString(value) {
    if (!this->isNumberString(value))
    {
        throw std::runtime_error("String should only contain numbers!");
    }
}

void NumberString::RemoveCharacter(char c = '5') {
    BaseString::RemoveCharacter(c);
}

bool NumberString::isNumberString(char *value) {
    int length = strlen(value);
    int numbers = 0;
    for (int i = 0; i < length; ++i) {
        if(isdigit(value[i])) {
            numbers++;
        }
    }
    return length == numbers;
}
