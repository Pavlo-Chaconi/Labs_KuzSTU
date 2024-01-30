def repeating_values_of_list(some_array):
    some_array.sort()
    repeating_values_list = []
    for i in range(1, len(some_array)):
        if some_array[i] == some_array[i-1]:
            repeating_values_list.append(some_array[i])
    return(repeating_values_list)

print(repeating_values_of_list([1, 1, 3, 2, 3, 4, 5, 6]))
