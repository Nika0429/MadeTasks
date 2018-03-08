1. Создали класс Programm, в нем вызвали метод Main с каким-то неясным параметром в виде массива строк.
 
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
