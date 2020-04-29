#include <stdexcept>
#include "Expression.h"
#include "cmath"

Expression::Expression(double a, double c, double d) {
    this->a = a;
    this->c = c;
    this->d = d;
}

double Expression::solve() const {
    double denominator = a * a - 1;
    double logres = d / 4;
    if (denominator == 0.0) {
        throw std::invalid_argument("Division by zero is prohibited.");
    }
    if (logres <= 0)
    {
        throw std::invalid_argument("Logarithm expression must be more than 0.");
    }

    return (2 * c - log(logres)) / denominator;
}


