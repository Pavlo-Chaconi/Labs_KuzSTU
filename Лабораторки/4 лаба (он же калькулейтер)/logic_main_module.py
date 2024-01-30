import arphmetic_module as arip


while True:
    print("Введите числа x и y, если хотите завершить работу калькулятора раньше введите значение 000")
    x = int(input("x"))
    if x == 000:
        break
    y =int(input("y"))
    math_action = input("Математическое действие")

    if math_action == "+":
        print("Результат",arip.adding(x, y))
    elif math_action == "-":

        print("Результат", arip.subtraction(x, y))
    elif math_action == "*":
        print("Результат", arip.multiplying(x, y))
    elif math_action == "/":
        print("Результат", arip.division(x, y))
