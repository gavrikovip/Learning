#Задать список из n чисел последовательности (1+1/n)^n и вывести на экран их сумму.

from itertools import accumulate


chain = [(1+1/n)**n for n in range(1, int(input('Введите число n:\n'))+1)]
print(sum(chain))
