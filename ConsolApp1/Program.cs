// Напишите программу, которая на вход 
// принимает число и выдает его квадрат (число умноженное само на себя)

Console.Write("Введите целое число: ");

int number_1 = int.Parse(Console.ReadLine());
// Квадрат входного числа
int result = number_1 * number_1;
//Вывод результата
Console.WriteLine(result);