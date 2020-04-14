//
// Created by Arthur Ladchenko on 14.04.2020.
//

#include "Triangle.h"
#include <iostream>
#include <cmath>

using namespace std;

Triangle::Triangle(int *coords, int size) : Shape(coords, size) {
    if (size != 6) {
        throw std::runtime_error("Triangle must have 3 and only 3 points.");
    }
}

void Triangle::TriangleData() {
    for (int i = 0; i < this->GetSize(); i++) {
        cout << "Point #";
        cout << i << endl;
        cout << "X: ";
        cout << this->points[i].x << endl;
        cout << "Y: ";
        cout << this->points[i].y << endl;
    }
}

float Triangle::TrianglePerimeter() {
    float perimeter = 0;
    for (int i = 0; i < this->GetSize(); i++) {
        perimeter += this->SideLength(i);
    }

    return perimeter;
}

float Triangle::TriangleArea() {
    float s = this->TrianglePerimeter() / 2;
    float a = this->SideLength(0);
    float b = this->SideLength(1);
    float c = this->SideLength(2);
    return sqrt(s * (s - a) * (s - b) * (s - c));
}


