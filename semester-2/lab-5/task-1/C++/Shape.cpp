//
// Created by Arthur Ladchenko on 14.04.2020.
//

#include "Shape.h"
#include <cmath>

Shape::Shape(int *coords, int size) {
    if (size % 2 == 0) {
        points = new Point[size / 2];
        int p = 0;
        for (int i = 0; i < size; i += 2) {
            Point np;
            np.x = coords[i];
            np.y = coords[i + 1];
            points[p] = np;
            p++;
        }
        shapePoints = p;
    } else {
        throw std::runtime_error("Coords amount should be even.");
    }
}

float Shape::SideLength(int sideIndex) {
    Point* side = GetSide(sideIndex);
    return sqrt(pow(side[0].x - side[1].x, 2) + pow(side[0].y - side[1].y, 2));
}

Point *Shape::GetSide(int sideIndex) {
    if (sideIndex <= GetSize() - 1 && sideIndex >= 0) {
        if (sideIndex != GetSize() - 1) {
            Point* side = new Point[2];
            side[0] = points[sideIndex];
            side[1] = points[sideIndex + 1];
            return side;
        } else {
            Point* side = new Point[2];
            side[0] = points[0];
            side[1] = points[GetSize() - 1];
            return side;
        }
    }
    throw std::runtime_error("There are no such side in this shape!");
}

int Shape::GetSize() {
    return this->shapePoints;
}
