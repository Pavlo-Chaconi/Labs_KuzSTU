def repeating_values_of_list(some_array):
    some_value = some_array[0]
    some_array.sort()
    repeating_values_list = []
    for i in some_array:
        if some_value == i:
            repeating_values_list.append(some_value)
        some_value = i
    return(repeating_values_liste)

print(repeating_values_of_list([1, 1, 3, 2, 3, 4, 5, 6]))