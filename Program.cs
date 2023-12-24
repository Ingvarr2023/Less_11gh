// Коментарий однострочный

// Напишите программу, которая на вход
// принимает два целых числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 =>

int number = 9; // number = 9
int result = number * number; // 81
// Console.ReadLine() - получить информацию из строчки;
Console.Write("Введите первое число: "); // a
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите первое число: "); // b
int secondNumber = Convert.ToInt32(Console.ReadLine());
// firstNumber == secondNumber * stcondNumber
if(firstNumber == secondNumber * secondNumber) // true
{
    Console.WriteLine("Да, " + firstNumber + " является кв. от числа " + secondNumber);
}
else // число a не явл. кв. числа b
{
    Console.WriteLine("Нет, " + firstNumber + " Не является кв. от числа " + secondNumber);
}

// Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2

Console.Write("Введите число  N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 0)
{
    Console.WriteLine("Введено N < 0");
    N = N * -1;
}
int negativeN = N * -1; // -4


while (negativeN <= N)
{
    Console.Write(negativeN + " "); //будет печатать в одной строке с пробелом
    negativeN++;
}

