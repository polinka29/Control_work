Пользователь вводит массив строк путем ввода с клавиатуры, необходимо вывести на печать новый массив строк,
который меньше или равен 3 символам.

Создаем массив Аrray с типом данных string, просим ввести пользователя с клавиатуры символы через пробел.

Объявляем переменную count =0 и цикл for(int i = 0; i < Array.Length; i++).

Условием if(Аrray[i].Length <= 3) проверяем равен ли массив 3м или меньше символам, счетчиком count перебираем.

Создаем новый  массив MyArray, который будет результатом программы.

Цикл for(int i = 0; i < MyArray.Length; i++) перебирает массив MyArray.

Цикл for (int j = 0; j < Array.Length; j++) перебирает масив Array.

Условием if (Array[j].Length <= 3 && Array[j] != string.Empty) обуславливем,что если массив Array меньше или равен 3м символам, при этом имеет не пустое значение, тогда массив MyArray равен массиву Array, при этом массив не пустой.

Результатом программы является вывод элементов массива MyArray, состоящих из строк, длина которых меньше либо равна 3м символам.

