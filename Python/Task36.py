# Дан список чисел. Создать список, в который попадают числа, описываемые возрастающую последовательность.
# Порядок элементов менять нельзя.


list = [2, 10, 8, 1, 1, 3, 4, 2, 6, 6, 7, 3, 4, 1, 9]

def chain(list):
    a = [list[0]]
    for i in list:
        if i > max(a):
            a.append(i)
    return a

print(chain(list))