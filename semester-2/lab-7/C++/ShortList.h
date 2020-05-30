using namespace std;

struct Node {
    short data;
    Node *next;
};

class ShortList {
private:
    Node *head;
public:
    ShortList() {
        head = nullptr;
    }
    void display();
    void insert(short value);
    void remove(short data);
    double average();
    int multiplesOfThree();
    int length();
    void removeAboveAverage();
    bool contains(short data);
};