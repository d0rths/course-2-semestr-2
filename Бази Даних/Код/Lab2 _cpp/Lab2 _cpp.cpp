#include <iostream>
#include <iomanip>
#include "Windows.h"

using namespace std;
// Клас, що представляє вузол дерева
class Node {
public:
    int Value;
    Node* Left;
    Node* Right;
};

// Класс бінарного дерева
class BTree {
    Node* Root;

    void DestroyTree(Node* leaf);
    void Insert(int key, Node* leaf);
    Node* Search(int key, Node* leaf);
    void InOrderPrint(Node* leaf);
    void PostOrderPrint(Node* leaf);
    void PreOrderPrint(Node* leaf);

public:
    // Конструктор
    BTree();
    // Деструктор
    ~BTree();

    // Додати елемент
    void Insert(int key);
    // Пошук елемента в дереві
    Node* Search(int key);
    // Видалити дерево
    void DestroyTree();
    // Виведення дерева
    void InOrderPrint();
    void PostOrderPrint();
    void PreOrderPrint();
};

BTree::BTree() {
    Root = NULL;
}

BTree::~BTree() {
    DestroyTree();
}

void BTree::DestroyTree(Node* leaf) {
    if (leaf != NULL)
    {
        DestroyTree(leaf->Left);
        DestroyTree(leaf->Right);
        delete leaf;
    }
}

void BTree::Insert(int key, Node* leaf) {
    if (key < leaf->Value)
    {
        if (leaf->Left != NULL)
            Insert(key, leaf->Left);
        else
        {
            leaf->Left = new Node;
            leaf->Left->Value = key;
            leaf->Left->Left = NULL;
            leaf->Left->Right = NULL;
        }
    }
    else if (key >= leaf->Value)
    {
        if (leaf->Right != NULL)
            Insert(key, leaf->Right);
        else
        {
            leaf->Right = new Node;
            leaf->Right->Value = key;
            leaf->Right->Right = NULL;
            leaf->Right->Left = NULL;
        }
    }
}

void BTree::Insert(int key) {
    if (Root != NULL)
        Insert(key, Root);
    else
    {
        Root = new Node;
        Root->Value = key;
        Root->Left = NULL;
        Root->Right = NULL;
    }
}

Node* BTree::Search(int key, Node* leaf) {
    if (leaf != NULL)
    {
        if (key == leaf->Value)
            return leaf;
        if (key < leaf->Value)
            return Search(key, leaf->Left);
        else
            return Search(key, leaf->Right);
    }
    else
        return NULL;
}

Node* BTree::Search(int key) {
    return Search(key, Root);
}

void BTree::DestroyTree() {
    DestroyTree(Root);
}

void BTree::PreOrderPrint() {
    PreOrderPrint(Root);
    cout << "\n";
}

void BTree::PreOrderPrint(Node* leaf) {
    int i = 1;
    int k = 1;
    if (leaf != NULL)
    {
        cout << i << "." << k << " " << leaf->Value << "\n";
        PreOrderPrint(leaf->Left);
        PreOrderPrint(leaf->Right);
    }
    else
    {
        i++;
        k = 1;
    }
}


int main()
{
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);

    BTree* tree = new BTree();

    // Додавання елементів в дерево

    tree->Insert(12);
    tree->Insert(8);
    tree->Insert(17);
    tree->Insert(7);
    tree->Insert(9);
    tree->Insert(14);
    tree->Insert(20);

    // Виведення дерева в різних порядках
    tree->PreOrderPrint();

    // Звільнення пам'яті
    delete tree;

    system("pause");
}

//        Вигляд дерева
// 
//              12
//      8               17
//  7       9       14      20
