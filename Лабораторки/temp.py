def multiply(lst):
    answer = 1
    for i in lst:
        answer *= i
    return answer
 
print(multiply([1, 2, 3, 4, 5]))