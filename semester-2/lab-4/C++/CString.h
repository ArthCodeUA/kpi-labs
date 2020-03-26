#include <string>

using namespace std;

class CString {
private:
    char *Value;
public:
    int GetLength();

    int CountChar(char c);

    char * GetValue();

    CString(int length);

    explicit CString(char *);

    CString(const CString &);

    CString operator+(CString &);

    CString operator-(char);
};