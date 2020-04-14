#include <iostream>
#include "Triangle.h"

int main() {
    int coordsAmount = 6;
    int* coords = new int[coordsAmount]{-1, 4, -1, 2, -7, 3};
    Triangle triangle = Triangle(coords, coordsAmount);
    triangle.TriangleData();
    cout << "Area is ";
    cout << triangle.TriangleArea() << endl;
    cout << "Perimeter is ";
    cout << triangle.TrianglePerimeter() << endl;
    return 0;
}