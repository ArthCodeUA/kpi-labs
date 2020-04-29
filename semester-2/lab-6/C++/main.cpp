#include <iostream>
#include "Expression.h"

using namespace std;

int main() {
    Expression expressions[3]{
        Expression(1, 2, 0),
        Expression(5, 2, 0),
        Expression(512, 231, 12)
    };
    for (const auto & expression : expressions) {
        try
        {
            double result = expression.solve();
            cout << result << endl;
        }
        catch (std::invalid_argument& e)
        {
            cout << e.what() << endl;
        }
    }
    return 0;
}