// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами 
// такой длины. Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

bool IsItTriangle(int a, int b, int c) // возвращает да или нет
{
    return a < b + c && b < a + c && c < a + b; // если 3 условия выполнились то правда. треугольник существует
}

Console.WriteLine("Введите первую сторону: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите вторую сторону: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третью сторону: ");
int c = int.Parse(Console.ReadLine()!);

bool answer = IsItTriangle(a, b, c);
if (answer)
{
    Console.WriteLine("Существует");
}
else
{
    Console.WriteLine("Не существует");
}
