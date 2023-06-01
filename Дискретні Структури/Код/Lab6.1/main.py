def evaluate_formula(formula, variable_values):
    output_queue = []
    operator_stack = []

    precedence = {'*': 2, '+': 1, '-': 1}

    for char in formula:
        if char.isalpha():
            output_queue.append(variable_values[char])
        elif char == '0':
            output_queue.append(0)
        elif char == '1':
            output_queue.append(1)
        elif char in ['*', '+', '-']:
            while operator_stack and operator_stack[-1] != '(' and precedence[char] <= precedence[operator_stack[-1]]:
                output_queue.append(operator_stack.pop())
            operator_stack.append(char)
        elif char == '(':
            operator_stack.append(char)
        elif char == ')':
            while operator_stack and operator_stack[-1] != '(':
                output_queue.append(operator_stack.pop())
            operator_stack.pop()

    while operator_stack:
        output_queue.append(operator_stack.pop())

    stack = []
    for token in output_queue:
        if token == '-':
            operand = stack.pop()
            stack.append(int(not operand))
        elif token == '*':
            operand2 = stack.pop()
            operand1 = stack.pop()
            stack.append(int(operand1 and operand2))
        elif token == '+':
            operand2 = stack.pop()
            operand1 = stack.pop()
            stack.append(int(operand1 or operand2))
        else:
            stack.append(token)

    return stack.pop()

formula = "(B) * (-A)"
variable_values = {'A': 1, 'B': 0, 'C': 1}

converted = formula.replace("*", "AND")
converted = converted.replace("+", "OR")
converted = converted.replace("-", "NOT ")


result = evaluate_formula(formula, variable_values)
print(f"Формула: {converted},\nде А = 1, В = 0, С = 1")
print("Результат:", result)
