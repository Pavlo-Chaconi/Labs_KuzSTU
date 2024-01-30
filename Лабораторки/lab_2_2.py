def max_num_counter(some_array):
    max_num = some_array[0]
    for i in some_array:
        if i > max_num:
            max_num = i
    return max_num

print(max_num_counter([1, 2, 3, 100, 93, 15, 1000, 102]))