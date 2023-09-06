//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
//вариант проще

int InputM(string mess)
{
    Console.Write(mess);
    return int.Parse(Console.ReadLine()!);
}


int CountPositivNums(int m)
{
    int count = 0;
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        if (int.Parse(Console.ReadLine()!) > 0)
            count++;
    }
return count;
}


int numM = InputM("Какое количество чисел вы введете? : ");
System.Console.WriteLine("ОК, вводите: ");
int countPositivNums = CountPositivNums(numM);
Console.Write($"\n Чисел больше нуля: {countPositivNums}");
