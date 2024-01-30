import math

def math_logic(x,y):
    first_math_result = (x ** 2 + 6 ** y) / (8 - math.exp(2))
    second_math_result = y*math.log(x)*(math.cos(1.0472)/math.tan(0.785398)) + y
    return first_math_result, second_math_result, round(first_math_result), round(second_math_result)

print(math_logic(6,1))
