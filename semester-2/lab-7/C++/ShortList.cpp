#include <iostream>
#include "ShortList.h"

void ShortList::insert(short value) {
    Node *temp = new Node;
    temp->data = value;
    temp->next = head;
    head = temp;
}


void ShortList::remove(short data) {
    Node *current = head;
    Node *previous = nullptr;
    if(this->contains(data)) {
        while (current != nullptr) {
            if (current->data == data) {
                if (previous != nullptr) {
                    previous->next = current->next;
                } else {
                    head = head->next;
                }
            }
            previous = current;
            current = current->next;
        }
    }
}

void ShortList::display() {
    Node *current = head;
    while (current != nullptr) {
        cout << current->data << "\t";
        current = current->next;
    }
    cout << endl;
}


double ShortList::average() {
    Node *current = head;
    double average = 0;
    while (current != nullptr) {
        average += current->data;
        current = current->next;
    }
    return average / this->length();
}

int ShortList::multiplesOfThree() {
    Node *current = head;
    int mot = 0;
    while (current != nullptr) {
        if (current->data % 3 == 0) mot++;
        current = current->next;
    }
    return mot;
}

void ShortList::removeAboveAverage() {
    Node *current = head;
    double average = this->average();
    while (current != nullptr) {
        if (current->data > average) this->remove(current->data);
        current = current->next;
    }
}

int ShortList::length() {
    Node *current = head;
    int length = 0;
    while (current != nullptr) {
        length++;
        current = current->next;
    }
    return length;
}

bool ShortList::contains(short data) {
    Node *current = head;
    while (current != nullptr) {
        if (current->data == data) return true;
        current = current->next;
    }
    return false;
}
