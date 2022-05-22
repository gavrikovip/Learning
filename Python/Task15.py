# 15. Написать программу, получающую набор произведений чисел от 1 до N.
# Пример: пусть N = 4, тогда
# [1, 2, 6, 24]
from itertools import accumulate
import operator


print(list(accumulate([n for n in range(1, int(input('Введите число n\n'))+1)], operator.mul)))
