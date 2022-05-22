# Подсчитать сумму цифр в вещественном числе.

sum = 0
for n in range(1, int(input('Введите число n:\n'))+1):
    sum = sum + n
print(sum)
