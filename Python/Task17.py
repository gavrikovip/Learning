#Задать список из N элементов, заполненных числами из [-N, N]. Найти произведение элементов на указанных позициях. Позиции хранятся в файле file.txt в одной строке одно число.

N = int(input('Введите число N:\n'))
multi = 1
numbers = [n for n in range(-N, N+1)]
print(numbers)

with open('file.txt', 'r') as data:
    for lines in data:
        multi = multi * int(lines)
    
print(multi)