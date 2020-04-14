//
// Created by Arthur Ladchenko on 15.04.2020.
//

#pragma once

class BaseString {
protected:
    char *value;
    int CountChar(char c);
    explicit BaseString(char *);
    virtual void RemoveCharacter(char c);

public:
    int GetLength();
    char * GetValue();
};