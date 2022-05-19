# 40. Создайте программу для игры с конфетами человек против человека.
# Условие задачи:
# На столе лежит 2021 конфета. Играют два игрока делая ход друг после друга. Первый ход определяется жеребьёвкой.
# За один ход можно забрать не более чем 28 конфет. Все конфеты оппонента достаются сделавшему последний ход.
# Сколько конфет нужно взять первому игроку, чтобы забрать все конфеты у своего конкурента?
# a) Добавьте игру против бота
# b) Подумайте, как наделить бота "интеллектом"
import random
from sndhdr import what
candy = 100

player1 = 0
player2 = 1
bot = 1
j = random.randint(0, 1)


def takeMeCandy(players, candy, j):
    player(j)
    players = int(input(f'Сколько конфет заберешь? Осталось всего {candy} \n'))
    if players > 28:
        print('Можно брать максимум 28 конфет, внимательнее!!')
        takeMeCandy(player(j), candy, j)
        candy = candy - players
    else:
        candy = candy - players
    return candy


def takeMeCandyForBotVsPlayer(players, candy):
    playerBot(0)
    players = int(input(f'Сколько конфет заберешь? Осталось всего {candy} \n'))
    if players > 28:
        print('Можно брать максимум 28 конфет, внимательнее!!')
        takeMeCandyForBotVsPlayer(player(0), candy)
    else:
        candy = candy - players
    return candy


def takeMeCandyBot(candy):
    print('Bot думает несколько мгновений...')
    b = random.randint(1, 28)
    if b > candy:
        b = random.randint(1, candy)
    print(f'Bot выбрал {b}')
    candy = candy - b
    return candy

def takeMeCandySmartBot(candy):
    print('Bot очень быстро думает...')
    b = candy % (28 + 1)
    if b == 0:
        b = random.randint(1, 28)
    if b > candy:
        b = candy
    print(f'Bot выбрал {b}')
    candy = candy - b
    return candy    


def gameWithBot(candy):
    print('Можно брать максимум 28 конфет')
    if j == 1:
        candy = takeMeCandyBot(candy)
    while candy > 0:
        candy = takeMeCandyForBotVsPlayer(player1, candy)
        i = 1
        if candy > 0:
            candy = takeMeCandyBot(candy)
            i = 2
    if i == 1:
        print('Ты выиграл у бота')
    else:
        print('Выиграл Bot')

def gameWithSmartBot(candy):
    print('Можно брать максимум 28 конфет')
    if j == 1:
        candy = takeMeCandySmartBot(candy)
    while candy > 0:
        candy = takeMeCandyForBotVsPlayer(player1, candy)
        i = 1
        if candy > 0:
            candy = takeMeCandySmartBot(candy)
            i = 2
    if i == 1:
        print('Ты выиграл у бота')
    else:
        print('Выиграл SmartBot, еще бы')


def game(candy):
    print('Можно брать максимум 28 конфет')
    while candy > 0:
        candy = takeMeCandy(player1, candy, j)
        i = 1
        if candy > 0:
            candy = takeMeCandy(player2, candy, j+1)
            i = 2
    if i == 1:
        print('Выиграл')
        player(j)
    else:
        print('Выиграл')
        player(j+1)


def player(j):
    if j % 2 == 0:
        chose = print('Первый игрок')
    else:
        chose = print('Второй игрок')
    return chose


def playerBot(j):
    if j == 1:
        j = 2
    if j % 2 == 0:
        chose = print('Первый игрок')
    else:
        chose = print('Бот')
    return chose
#takeMeCandy(player1, candy)

def whatGame(a):
    if a == 1:
        game(candy)
    elif a == 2:
        gameWithBot(candy)
    elif a == 3:
        gameWithSmartBot(candy)
    else: 
        print('Давай еще разок..')
        a = int(input('1. С другим игроком\n2. С ботом\n3. С умным ботом, у которого почти нельзя выиграть\n'))
        whatGame(a)

print('Выберай с кем играть:')
a = int(input('1. С другим игроком\n2. С ботом\n3. С умным ботом, у которого почти нельзя выиграть\n'))
whatGame(a)

