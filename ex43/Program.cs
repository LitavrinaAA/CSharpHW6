// Задача 43: Напишите программу, 
//которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//k1 * x + b1 = k2 * x + b2
//(k1 - k2) * x = b2 - b1
//x = (b2 - b1) / (k1 - k2)

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
int InputValue(string mess){
   Console.WriteLine(mess);
   return int.Parse(Console.ReadLine()!); 
}
double GetX(int b1, int b2, int k1, int k2){
    double res = (double)(b2 - b1)/(k1 - k2);  
    return res;
}

double GetY(int b2, int k2, double x){
    
    return k2 * x + b2;
}
int b1 = InputValue("введите значение b1");
int k1 = InputValue("введите число k1");

int b2 = InputValue("введите значение b2");
int k2 = InputValue("введите число k2");


double x = GetX(b1, b2, k1, k2);
double y = GetY(b2, k2, x);

System.Console.WriteLine(x);
System.Console.WriteLine(y);

Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");