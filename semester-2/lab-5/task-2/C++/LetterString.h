//
// Created by Arthur Ladchenko on 15.04.2020.
//

#include "BaseString.h"

class LetterString : public BaseString {
public:
    explicit LetterString(char* value);
    void RemoveCharacter(char c) override;
private:
    bool isLetterString(char* value);
};
