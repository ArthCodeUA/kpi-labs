#include <cstring>
#include "CString.h"

int CString::GetLength() {
    return strlen(this->Value);
}

char *CString::GetValue() {
    return this->Value;
}

CString::CString(int length) {
    this->Value = new char[length];
}

CString::CString(char *value) {
    this->Value = value;
}

CString::CString(const CString &cString) {
    this->Value = cString.Value;
}

CString CString::operator+(CString &nw) {
    int newLength = this->GetLength() + nw.GetLength();
    CString newString = CString(newLength);
    for (int i = 0; i < newLength; i++) {
        if (i < this->GetLength()) {
            newString.Value[i] = this->Value[i];
        } else {
            newString.Value[i] = nw.Value[i - this->GetLength()];
        }
    }
    return newString;
}

CString CString::operator-(char c) {
    CString newString = CString(this->GetLength() - this->CountChar(c));
    int step = 0;
    for (int i = 0; i < this->GetLength(); i++) {
        if (c == this->Value[i]) { continue; }
        newString.Value[step] = this->Value[i];
        step++;
    }
    return newString;

}

int CString::CountChar(char c) {
    int counter = 0;
    for (int i = 0; i < this->GetLength(); ++i) {
        if (this->Value[i] == c) counter++;
    }
    return counter;
}
