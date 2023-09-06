//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
String InputM(string mess)
{
    System.Console.WriteLine(mess);
    return Console.ReadLine();
}
void PrintArray(int[] array)
{
    System.Console.WriteLine("size: " + array.Length);
    Console.WriteLine(String.Join(",", array));

}
int[] StringToNum(string input, int size)
{    
    int[] tempArr = new int[size];
    
    char tempChar = ' ';
    string temp = "";
    
    int j = 0;
    
    
    for (int i = 0; i < input.Length; i++)
    {
        if (Char.IsNumber(input[i]))
        {

            if (tempChar.Equals(' '))
            {
                tempArr[j] = Convert.ToInt32(Char.GetNumericValue(input[i]));
            }
            else if (tempChar.Equals('-'))
            {
                //склеиваем "-" и цифру
                temp = $"{tempChar}{input[i]}";
                tempArr[j] = int.Parse(temp);
                //очищаем переменные
                tempChar = ' ';
                temp = "";
            }
            // счетчик по int массиву (только когда добавили что-то в массив 
            j++;
        }
        else if (input[i].Equals('-'))
        {
            tempChar = input[i];
        }

    }
    return tempArr;
}
int CountPositivNums(int[] arr)
{
    int Count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
            Count++;
    }
    return Count;
}
int SizeArr(String str)
{
    int length = str.Length;
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        //if (!str[i].Equals('-')) 
        if (Char.IsNumber(str[i]))
            count++;
    }
    return count;
}
string numStr = InputM("Введите числа : ");
int sizeArr = SizeArr(numStr);
int[] numArr = StringToNum(numStr, sizeArr);
PrintArray(numArr);
int countPos = CountPositivNums(numArr);
System.Console.WriteLine($"Число позитивных чисел: {countPos}");
