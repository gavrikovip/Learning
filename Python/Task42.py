# Реализуйте RLE алгоритм: реализуйте модуль сжатия и восстановления данных. Входные и выходные данные хранятся в отдельных текстовых файлах.

from turtle import st
import re

#Метод сжатия

def zip():
    with open('arhive.txt', 'w') as data:
        data.write('aabbbaadddddddddddddddddrrrrrrrrrrrrrrrrrra')
    with open('arhive.txt', 'r') as data:
        string = data.readline()

    count = 1
    res = ''
    firstchar = 0
    for i in string:
        nextchar = firstchar + 1
        if nextchar < len(string):
            if string[firstchar] == string[nextchar]:
                count = count + 1
                firstchar = firstchar + 1
            else:
                res = res + str(count) + string[firstchar]
                count = 1
                firstchar = firstchar + 1
    res = res + str(count) + string[len(string)-1]

    with open('arhive.txt','w') as data:
        data.writelines(string + "\n" + res)

#Метод восстановления данных

def unzip():
    with open('unzip.txt','w') as data:
        data.write('12a2b1c5d6q')
    with open('unzip.txt','r') as data:
        string = data.readline()

    def separate(string):
        c = []
        s = ''
        num = 0
        for i in string:
            if i.isdigit() == True:
                s = s + i
                num = int(s)
            else:
                c.append(num*i)
                num = 1
                s = ''
        return c

    s = separate(string)

    def printOFF(s):
        a = ''
        for i in s:
            a = a + i
        return a

    res = printOFF(s)
    with open('unzip.txt','w') as data:
        data.writelines(string + "\n" + res)

zip()
unzip()
