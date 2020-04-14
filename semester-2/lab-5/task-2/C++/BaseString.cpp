//
// Created by Arthur Ladchenko on 15.04.2020.
//

#include <cstring>
#include "BaseString.h"

int BaseString::GetLength() {
    return strlen(this->value);
}

char *BaseString::GetValue() {
    return this->value;
}

BaseString::BaseString(char *value) {
    this->value = value;
}

int BaseString::CountChar(char c) {
    int counter = 0;
    for (int i = 0; i < this->GetLength(); ++i) {
        if (this->value[i] == c) counter++;
    }
    return counter;
}

void BaseString::RemoveCharacter(char c) {
    char* newString = new char[this->GetLength() - this->CountChar(c)];
    int step = 0;
    for (int i = 0; i < this->GetLength(); i++) {
        if (c == this->value[i]) { continue; }
        newString[step] = this->value[i];
        step++;
    }
    value = newString;
}
