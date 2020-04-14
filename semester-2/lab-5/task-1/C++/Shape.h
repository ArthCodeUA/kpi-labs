#include <string>
#include <vector>

using namespace std;

struct Point {
    int x;
    int y;
};

class Shape {
protected:
    Point* points;
    int shapePoints;
    int GetSize();
    float SideLength(int sideIndex);
    Point* GetSide(int sideIndex);
    Shape(int *coords, int size);
};