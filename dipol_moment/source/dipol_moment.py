from math import *

bonds = []
M = 1.0
n = 0
atoms = { "H" : 2.2, "C" : 2.55, "P" : 2.19, "O" : 3.44, "N" : 3.04 }

print("Введите длины связей (N-H = 1.01):")
while (s := input()):
    a, d = "".join(i for i in s if i != " ").upper().split("=")      # Убираем все пробелы, приводим к верхнему регистру и делим на атомы в связи и на её длину
    bonds.append((a.split("-"), float(d)))                           # Добавляем связь в массив в виде пары атомов и длины
    
print("Введите углы связей в градусах (H-N-H = 106):")
while (s := input()):
     a, angle = "".join(i for i in s if i != " ").upper().split("=") # Убираем все пробелы, приводим к верхнему регистру и делим на тройку атомов и на угол между ними
     a1, a2, a3 = a.split("-")                                       # Получаем имена атомов
     angle = float(angle)
     for b in bonds:                                                 # Ищем длину первой связи в тройке
         if [a1, a2] == b[0] or [a2, a1] == b[0]:
             m1 = abs(atoms[a1[0]] - atoms[a2[0]]) * b[1]
             break
     for b in bonds:                                                 # Ищем длину второй связи в тройке
         if [a2, a3] == b[0] or [a3, a2] == b[0]:
             m2 = abs(atoms[a2[0]] - atoms[a3[0]]) * b[1]
             break
     M *= sqrt(m1**2 + m2**2 - 2 * m1 * m2 * cos(angle * pi / 180))  # Добавляем дипольный момент тройки
     n += 1
print("Дипольный момент химической связи:", pow(M, 1/n))             # Вычисляем среднее геометрическое дипольных моментов и выводим его
input()