//Задача 29: 
//Напишите программу,
//которая задаёт массив из 8 элементов и выводит их на экран.


//Создаем перемменную array говоим что там целые числа и это массив, далее пишем новый целые чила массив из 8 числел
int[] array = new int[8];
//Решениче через цикл фор где (i говорит нам за index массива, i меньше длинны массива, i = i + i)
for (int i = 0; i < array.Length; i++)
{
    //Потом мы записываем в индекс нашего массива это array[i], новые рандомные числа от 1 до 10
    array[i] = new Random().Next(1, 10);
    //Вывод в консоли числа идут строкой соблюдая 1 пробел, чтобы вывести в столбик нужно прописать WriteLine
    Console.Write($"{array[i]} ");
}
//Тут мы делаем перенос строки
Console.WriteLine();
// Решение через цикл while 
// Задаем переменную index со значением 0
int index = 0;
// Условие выполнения цикла пока index меньше длинны массива
while (index < array.Length)
{
    //Выполняется действие в наш массив под его индексом записываем значение рандомное от 1 до 10
    array[index] = new Random().Next(1, 10);
    //Выполняет вывод записи через 1 пустой пробел
    Console.Write($"{array[index]} ");
    //Добавляем к индексу 1 чтобы программа не делала его бесконечно. Цик While работае в условия True and False.
    index++;
}
//отделение строкой
Console.WriteLine();
// Подглядывая в менинар пробую решить задачу через метод  void
void NewArray(int[] collection)
{
    int index = 0;
    while (index < collection.Length)
    {
        collection[index] = new Random().Next(1, 10);
        //Console.Write($"{collection[index]} ");
        //index = index + 1 Чтобы закончить цекл иначе он бедет бесконечный 
        index++;
    }
}
//Этот метод выводит массив но его межно и не прописывать, а написать все в одном.
void PrintArray(int[] col)
{
    // Обозначаем index к col
    int indexPrintArray = 0;
    // Цикл While пока index меньше длинны массива цилк работает
    while (indexPrintArray < col.Length)
    {
        // В цикле происходит печать массива
        Console.Write($"{col[indexPrintArray]} ");
        indexPrintArray++;
    }
}
NewArray(array);
PrintArray(array);
// В методах я еще путаюсь, при написании метода я подглядывал как его писали на лекции. 