import arphmetic_module as arip

start_trigger = 1
while start_trigger == 1:
    print("Введите числа x и y, если хотите завершить работу калькулятора раньше введите значение 000")
    x = int(input("x"))
    if x == 000:
        break
    y =int(input("y"))
    math_action = input("Математическое действие")

    if math_action == "+":
        result = arip.adding(x, y)
        print("Результат", result)
    elif math_action == "-":
        result = arip.division(x, y)
        print("Результат", result)
    elif math_action == "*":
        result = arip.multiplying(x, y)
        print("Результат", result)
    elif math_action == "/":
        result = arip.division(x, y)
        print("Результат", result)
