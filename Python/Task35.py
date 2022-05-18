# В файле находится N натуральных чисел, записанных через пробел.
# Среди чисел не хватает одного, чтобы выполнялось условие A[i]-1 = A[i-1].
# Найдите это число.
with open('Nчисел.txt', 'r') as data:
    s = list(data.readline().split())
print(s)
# Преобразование строк в числа
a = []
for i in s:
    try:
        a.append(int(i))
    except ValueError:
        pass
print(a)
# Вывод найденного числа
def num(a):
    for j in a:
        try:
            if(a[j] - 1 == a[j-1]):
                j += 1
            else:
                return print(f'{j+1}')
            if j == len(a):
                print('Все числа на месте')
        except ValueError:
            pass
num(a)
