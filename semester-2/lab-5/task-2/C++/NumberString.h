//
// Created by Arthur Ladchenko on 15.04.2020.
//

#include "BaseString.h"

class NumberString : public BaseString {
public:
    explicit NumberString(char* value);
    void RemoveCharacter(char c) override;
private:
    bool isNumberString(char* value);
};
