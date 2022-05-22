# 11. Сформировать список из  N членов последовательности. Для N = 5: 1, -3, 9, -27, 81 и т.д.

chain = [3**n if n % 2 == 0 else -3**n for n in range(0, int(input('Введите N\n')))]
print(chain)
