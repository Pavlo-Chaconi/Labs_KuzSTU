def list_sum_func(some_num_list):
     sum = 0
     for i in some_num_list:
         sum = sum + i
     return sum

def list_multiplication_func(some_num_list):
    multiplication_result = 1
    for i in some_num_list:
        multiplication_result *= i
    return multiplication_result

print(list_multiplication_func([1, 10, 15, 100]))