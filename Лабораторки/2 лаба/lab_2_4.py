def list_replcaer(some_array):
    index_of_minimum = 0
    index_of_maximum = 0
    for i in range(1, len(some_array)):
        if some_array[i] < some_array[index_of_minimum]:
            index_of_minimum = i
        if some_array[i] > some_array[index_of_maximum]:
            index_of_maximum = i
    
    some_array[index_of_minimum], some_array[index_of_maximum] = some_array[index_of_maximum], some_array[index_of_minimum]
    return some_array

print(list_replcaer([1000, 1020, 33, 20220]))