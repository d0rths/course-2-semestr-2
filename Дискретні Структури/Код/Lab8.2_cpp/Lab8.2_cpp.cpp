#include <stdlib.h>
#include <stdio.h>
#include <iostream>
#include <time.h>

using namespace std;

#define move_types 8

int possible_moves[move_types][2] = {
        {-1, -2}, {-2, -1}, {-2,  1}, { 1, -2},
        {-1,  2}, { 2, -1}, { 1,  2}, { 2,  1}
};

int** global;
int size_x, size_y;
int max_moves, back_ret;



int move_possible(int x, int y)
{
    return x >= 0 && y >= 0 && x < size_x && y < size_y && global[x][y] == 0;
}


int find_path(int cur_x, int cur_y, int move_num)
{
    int next_x = 0, next_y = 0;
    global[cur_x][cur_y] = move_num;

    if (move_num > max_moves)
        return 1;

    for (int i = 0; i < move_types; i++)
    {
        next_x = cur_x + possible_moves[i][0];
        next_y = cur_y + possible_moves[i][1];
        if (move_possible(next_x, next_y) && find_path(next_x, next_y, move_num + 1))
            return 1;
    }

    global[cur_x][cur_y] = 0;
    back_ret++;
    move_num++;
    return 0;
}




void main()
{
    setlocale(LC_ALL, "");

    int i, nrows, ncols, sy, sx, ** desc = NULL;
    time_t start, end;

    cout << "Введіть розмір дошки (від 2 до 8) :" << endl
        << "по осі \"X\"\t"; cin >> size_x;
    cout << "по осі \"Y\"\t"; cin >> size_y;
    if (size_x > 8 || size_x < 2 || size_y>8 || size_y < 2)
    {
        cout << "Неправильний розмір"; system("pause"); return;
    }

    cout << "Введіть початкові координати:" << endl
        << "Координата по осі\"X\"\t"; cin >> sx;
    cout << "Координата по осі\"Y\"\t"; cin >> sy;




    desc = (int**)malloc(sizeof(int) * size_x);
    for (i = 0; i < size_x; ++i)
        desc[i] = (int*)malloc(sizeof(int) * size_y);


    back_ret = 0;
    global = desc;
    max_moves = size_x * size_y - 1;


    for (int i = 0; i < size_x; ++i) {
        for (int j = 0; j < size_y; ++j)
            global[i][j] = 0;
    }



    if (find_path(sx, sy, 1)) {
        cout << "___________________________________________" << endl
            << "\t*********Розв\'язок*********" << endl
            << "___________________________________________" << endl;
        for (int i = 0; i < size_x; ++i) {
            cout << endl;
            for (int j = 0; j < size_y; ++j)
                cout << global[i][j] << "\t";
            cout << endl;
        }
        cout << "___________________________________________" << endl;
    }
    else cout << "Немає розв\'язку" << endl;



    for (i = 0; i < size_x; ++i)
        free(desc[i]);
    free(desc);




    system("pause");
}