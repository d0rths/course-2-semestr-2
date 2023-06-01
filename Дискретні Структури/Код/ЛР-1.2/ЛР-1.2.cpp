#include<iostream>
#include<iomanip>
#include <set>

using namespace std;

void showPowerSet(int* set, int set_length) {
    unsigned int size = pow(2, set_length);
    for (int counter = 0; counter < size; counter++) {
        cout << "{";
        for (int j = 0; j < size; j++) {
            if (counter & (1 << j))
                cout << set[j] << " ";
        }
        cout << "}" << endl;
    }
}

int main() {
    set <int> K{ 1,3,3 };

    int* set = new int[K.size()];
    int i = 0;
    for (auto item : K) {
        set[i] = item;
        i++;
    }

    showPowerSet(set, K.size());
}