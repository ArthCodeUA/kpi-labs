//
// Created by Arthur Ladchenko on 14.04.2020.
//


#include "Shape.h"

class Triangle : public Shape {
public:
    Triangle(int* coords, int size);
    void TriangleData();
    float TrianglePerimeter();
    float TriangleArea();
};