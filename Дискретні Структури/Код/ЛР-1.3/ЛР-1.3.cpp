#include<iostream>
#include<iomanip>
#include <set>

using namespace std;

void showPowerSet(char* set, int set_length, string* t) {
    unsigned int size = pow(2, set_length);
    string* str = new string[size];

    for (int counter = 0; counter < size; counter++) {
        for (int j = 0; j < size; j++) {
            if (counter & (1 << j))
                str[counter] += set[j];
        }
    }

    cout << "{" << str[0] << "}\n";
    bool check;
    for (int i = 1; i < size; i++)
    {
        for (int j = 0; j < sizeof(t); j++)
        {
            if (str[i] != t[j])
            {
                check = true;
            }
            else
            {
                check = false;
                break;
            }
        }
        if (check == true)
        {
            cout << "{" << str[i];
        }
        else
        {
            continue;
        }
        cout << "}" << endl;
    }
}

int main() {
    set <string> T{ "a","b" };

    set <char> K;
    for (auto item : T)
    {
        for (auto j : item)
        {
            K.insert(j);
        }
    }

    char* set = new char[K.size()];
    int i = 0;
    for (auto item : K) {
        set[i] = item;
        i++;
    }

    string* setT = new string[T.size()];
    i = 0;
    for (auto item : T) {
        setT[i] = item;
        i++;
    }

    showPowerSet(set, K.size(), setT);
}