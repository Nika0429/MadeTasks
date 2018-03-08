***Результат выполнения программы:***

Container numbers: 1, 2, 3, 4, 5, 6, 7, 8, 9.

Container min & max: 1 & 9.

Min & max after Increase call: 1 & 9.

Flipped min & max: 9 & 1.

Container odd numbers: 1, 3, 5, 7, 9.

Container even numbers: 2, 4, 6, 8.

Odd container numbers: 1, 3, 5, 7, 9.

Odd container numbers: 2, 4, 6, 8.

Container min & max after reset: 0 & 0.

Press any key to continue...

***Описание выполнения программы:***

_1. Создали пространство имен RefOutParameters;_

2. Создали public класс Container c public автоматически реализуемыми свойствами:
- типа целочисленный int массив чисел Numbers
- типа целочисленный int массив чисел Odds
- типа целочисленный int массив чисел Evens
- типа int Min
- типа int Max
- типа int MinOdd
- типа int MaxOdd
- типа int MinEven
- типа int MaxEven

_3. Создали статический метод FindMinMax без функции возврата значения, с параметрами :_
 - целочисленный int массив чисел numbers
 - out int min
 - out int max

   Метод записывает в исходящие параметры наименьшее и наибольшее значение из 
   массива number при помощи встроенной фукции

_4. Создали статический метод Flip невозвращаемый, с параметрами :_
 - ref int a;
 - ref int b;

   Метод меняет местами значения из а в б и из б в а. 
   Так как параметры ref, то замена произойдет именно с поданными объектами.

_5. Статический метод Increase с параметром int value_

   Метод берет значение параметра, увиличивает его на один 
   и присваетвает своей переменной которую возвращает.

_6. Статический метод Create, возвращаемый тип Container_

   Метод создает новый объект класса Container и ему в свойство Numbers записывает нат. числа от 1 до 9.

_7. Статический метод Copy, возвращаемый тип Container_
 
   Метод создает копию объекта с тем же значением свойства Numbers

_8. Статический метод Split, с параметрами_
 - типа Container container
 - out типа Container oddContainer
 - out типа Container evenContainer

   Метод присваивает cвойству Numbers от oddContainer значение свойства Odds из сontainer, аналогично с Even

_9. Статический метод Reset, c ref параметром сontainer типа Container_
 
   Метод сбрасывает все свойства объекта container кроме Numbers

_10. Статический метод FindOdds, с параметром объект container_

   Метод отбирает все нечетные числа и записывает их в свойство Odds объкта класса Container

_11. Статический метод FindEvens, с параметром объект container_

   Метод отбирает все четные числа и записывает их в свойство Evens объкта класса Container
   
Класс Programm и собственно выполнение:

﻿1. Создали класс Programm, в нем вызвали метод Main с каким-то неясным параметром в виде массива строк.
 
2. Объявили две локальные переменные int Min и Max.

3. Объявили переменные container, oddContainer, evenContainer типа Container.

4. Вызвали метод Create() по отношению к container; 
   после этого вывели на экран все значения из свойства через пробел и запятую container.Numbers.
   Это будет: Container numbers: 1, 2, 3, 4, 5, 6, 7, 8, 9.
   
5. Вызвали метод FindMinMax и подали как параметры свойство Number объекта container, out min, out max.
   Потом значение min и max присваиваем свойствам объекта container Min и Max.
   Выводим на экран Min и Max, это будет: Container min & max: 1 & 9.
   
6. Вызываем метод Increase c параметром min и с параметром max. Параметры min и max остаются неизменными, 
   так как они не ref, т.е. метод вернул отдельную переменную, у которой значение это min+1.
   Выводим на экран min и max после вызова метода Increase. Это будет: Min & max after Increase call: 1 & 9.

7. Вызываем метод Flip с параметрами ref min и ref max. Метод записывает оригинальное значение min в max
   и оригинальное значение max в min. Выводим на экран текущие значения min и max. Это будет: Flipped min & max: 9 & 1.

8. Вызываем метод FindOdds с параметром container. Метод находит все нечетные числа из container.Number и присваивает их container.Odds.
   Выводим на экран: Container odd numbers: 1, 3, 5, 7, 9.

9. Вызываем метод FindEvens с параметром container. Метод находит все четные числа из container.Number и присваивает их container.Evens.
   Выводим на экран: Container even numbers: 2, 4, 6, 8.

10. Вызываем метод Split с параметрами container, out oddContainer, out evenContainer. 
    Метод присваивает oddContainer и evenContainer container.Odds и container.Evens.
    Выводим на экран container.Odds и container.Evens. Это:
    Odd container numbers: 1, 3, 5, 7, 9.
    Odd container numbers: 2, 4, 6, 8.

11. Вызываем метод Reset c параметром ref container. У сontainer все сбрасывается, кроме Numbers. 
    Выводим Min и Max после сброса, получаем: Container min & max after reset: 0 & 0.

