#include <iostream>
#include "CString.h"

using namespace std;

int main()
{
    char* initial = (char*) "cd#";
    CString s1 = CString(0);
    CString s2 = CString(initial);
    CString s3 = CString(s2);
    cout << s1.GetValue() << endl;
    cout << s2.GetValue() << endl;
    cout << s3.GetValue() << endl;
    s2 = s2 - '#';
    cout << s2.GetValue() << endl;
    s1 = s2 + s3;
    cout << s1.GetValue() << endl;
    return 0;
}
