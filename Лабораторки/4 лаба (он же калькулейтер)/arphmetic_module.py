def adding(x, y):
    result = x + y
    return result

def subtraction(x, y):
    result = x - y
    return result

def multiplying(x, y):
    result = x * y
    return result

def division(x, y):
    if y == 0:
        return("Деление на ноль невозможно!")
    else:
        result = x / y
    return result
