// Задача 43: Напишите программу, 
//которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//k1 * x + b1 = k2 * x + b2
//(k1 - k2) * x = b2 - b1
//x = (b2 - b1) / (k1 - k2)

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
int InputValue(string mess){
   Console.WriteLine("введите значение b1");
   return int.Parse(Console.ReadLine()!); 
}
double GetX(int b1, int b2, int k1, int k2){
    return (b2 - b1)/(k1 - k2);
}

double GetY(int b1, int b2, int k1, int k2, double x){
    return k2 * x + b2;
}
int b1 = InputValue("введите значение b1");
int k1 = InputValue("введите число k1");

int b2 = InputValue("введите значение b2");
int k2 = InputValue("введите число k2");


double x = GetX(b1:b1, b2:b2, k1:k1, k2:k2);//(-b2 + b1)/(-k1 + k2);
double y = GetY(b1:b1, b2:b2, k1:k1, k2:k2, x:x);//k2 * x + b2;

Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");