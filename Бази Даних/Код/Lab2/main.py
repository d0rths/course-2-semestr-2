from collections import deque

# Клас для зберігання вузла бінарного дерева.
class Node:
    def __init__(self, data=None, left=None, right=None):
        self.data = data
        self.left = left
        self.right = right

def build_tree_from_file(filename):
    with open(filename, 'r') as file:
        data = file.readline().strip()  # Зчитування рядка з файлу
        return build_tree(data)

def build_tree(data):
    if not data:
        return None

    # Рекурсивна функція для побудови дерева
    def build_subtree(data_list):
        if not data_list:
            return None

        value = ""
        while data_list and data_list[0] not in "()":
            value += data_list.pop(0)

        if value == "":
            return None

        node = Node(int(value))
        if data_list and data_list[0] == "(":
            data_list.pop(0)  # Видалення лівої дужки
            node.left = build_subtree(data_list)
            data_list.pop(0)  # Видалення правої дужки

        if data_list and data_list[0] == "(":
            data_list.pop(0)  # Видалення лівої дужки
            node.right = build_subtree(data_list)
            data_list.pop(0)  # Видалення правої дужки

        return node

    # Розбиття рядка на список символів
    data_list = list(data)
    return build_subtree(data_list)


# Збереження дерева у файл
def save_tree_to_file(root, filename):
    with open(filename, 'w') as file:
        data = serialize_tree(root)  # Серіалізація дерева
        file.write(data)

def serialize_tree(root):
    if root is None:
        return ""

    data = str(root.data)

    if root.left is not None or root.right is not None:
        data += "(" + serialize_tree(root.left) + ")(" + serialize_tree(root.right) + ")"

    return data






# Обхід дерева в попередньому порядку та збереження вузлів у словнику,
# що відповідає їх рівню
def preorder(root, level, d):
    # Базовий випадок: пусте дерево
    if root is None:
        return
    def traverse(node, path):
        if node is None:
            return

        print(path, '-', node.data)

        if node.left:
            traverse(node.left, path + ".1")

        if node.right:
            traverse(node.right, path + ".2")

    traverse(root, "1")

def replace(root, old_value, new_value):
    if root is None:
        return

    if root.data == old_value:
        root.data = new_value

    replace(root.left, old_value, new_value)
    replace(root.right, old_value, new_value)

def cut_subtree(root, target):
    if root is None:
        return None

    if root == target:
        return None

    root.left = cut_subtree(root.left, target)
    root.right = cut_subtree(root.right, target)

    return root

def dfs(node, criterion):
    if node is None:
        return None

    # Пошук найбільшого вузла
    if criterion == 'maximum':
        if node.right:
            return dfs(node.right, criterion)
        else:
            return node.data

    # Пошук найменшого вузла
    elif criterion == 'minimum':
        if node.left:
            return dfs(node.left, criterion)
        else:
            return node.data

    return None
def dfs_find(node, value, path="1"):
    if node is None:
        return None

    if node.data == value:
        return (node.data, path)

    left_result = dfs_find(node.left, value, path + ".1")
    if left_result:
        return left_result

    right_result = dfs_find(node.right, value, path + ".2")
    if right_result:
        return right_result

    return None
# Функція для виведення номера вузла з його ієрархією
def print_node_with_path(node_value, node_path):
    if node_path:
        print(f"Вузол {node_path}: {node_value}")
    else:
        print(f"Кореневий вузол: {node_value}")


def bfs(node, criterion, target_level=None):
    if node is None:
        return None

    queue = deque([(node, 0)])
    result = []

    while queue:
        current_node, level = queue.popleft()

        # Пошук найбільшого вузла
        if criterion == 'найбільший':
            if not result or current_node.data > result[0]:
                result = [current_node.data]

        # Пошук найменшого вузла
        elif criterion == 'найменший':
            if not result or current_node.data < result[0]:
                result = [current_node.data]

        # Пошук вузлів на певному рівні
        elif criterion == 'рівень':
            if level == target_level:
                result.append(current_node.data)

        if current_node.left:
            queue.append((current_node.left, level + 1))
        if current_node.right:
            queue.append((current_node.right, level + 1))

    return result

def bfs_find(node, value, path="1"):
    if node is None:
        return None

    if node.data == value:
        return (node.data, path)

    left_result = dfs_find(node.left, value, path + ".1")
    if left_result:
        return left_result

    right_result = dfs_find(node.right, value, path + ".2")
    if right_result:
        return right_result

    return None

# Рекурсивна функція для друку обходу заданого бінарного дерева за рівнями
def levelOrderTraversal(root):
    # створює порожній словник для зберігання вузлів між заданими рівнями
    d = {}

    # проходить по дереву і вставляє його вузли у словник
    # відповідний їхньому рівню
    preorder(root, 1, d)

    # виконує ітерацію за словником та друкує всі вузли між заданими рівнями
    for i in range(1, len(d) + 1):
        print(f'Level {i}:', d[i])


if __name__ == '__main__':
    # Ім'я файлу з даними про дерево
    filename = "tree_data.txt"
    # Зчитування дерева з файлу
    root = build_tree_from_file(filename)


    # Виведення дерева
    print("Виведення дерева")
    levelOrderTraversal(root)

    # Додавання вузла
    print('\n')
    print("Додавання вузла в дерево")
    root.right.right.left = Node(28)
    levelOrderTraversal(root)

    # Зміна елемента дерева
    print('\n')
    print("Зміна елемента 10 на 11 в дереві")
    replace(root, 10, 11)
    levelOrderTraversal(root)


    print('\n')
    # Пошук "в глибину" (DFS)
    # Пошук найбільшого вузла
    print("Пошук \"в глибину\"")
    maximum_node = dfs(root, 'maximum')
    print("Найбільший вузол:", maximum_node)

    # Пошук найменшого вузла
    minimum_node = dfs(root, 'minimum')
    print("Найменший вузол:", minimum_node)

    # Пошук вузла зі значенням 16
    found_node = dfs_find(root, 16)
    if found_node:
        value, path = found_node
        print_node_with_path(value, path)
    else:
        print("Вузол не знайдено")

    print('\n')
    # Пошук "в ширину" (ВFS)
    # Пошук найбільшого вузла
    print("Пошук \"в ширину\"")
    max_node = bfs(root, 'найбільший')
    print("Найбільший вузол:", max_node[0])
    # Пошук найменшого вузла
    min_node = bfs(root, 'найменший')
    print("Найменший вузол:", min_node[0])
    # Пошук вузла зі значенням 11
    found_node = bfs_find(root, 11)
    if found_node:
        value, path = found_node
        print_node_with_path(value, path)
    else:
        print("Вузол не знайдено")

    print('\n')
    print("Відсікання частини дерева у вузлі 1.2")
    cut_subtree(root, root.right)
    levelOrderTraversal(root)

    # Ім'я файлу для збереження даних
    filename = "new_tree_data.txt"
    # Збереження дерева у файл
    save_tree_to_file(root, filename)