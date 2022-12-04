# **Итоговое задание:**
Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма.
При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Решение

1. Объявляем массив array с определенным количеством элементов.
2. Реализуем ввод элементов массива пользователем с клавиатуры:
- создаем цикл от 0 до заданного количества элементов, в котором будем вводить строки массива;
- создаем цикл для вывода на экран элементов массива.
3. Объявляем новый массив array2, количество символов которого равно введенному ранее.
4. Пишем метод, в котором в цикле проверяется условие о том, что длина строки i-го элемента массива array <=3.Если условие выполняется, записываем данный элемент в новый массив array2 и проверяем следующий. Если нет - проверяем следующий, пока выполняется условие цикла.
5. Пишем метод вывода нового массива на экран, используя цикл.