// task 1
Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int len = number.Length;

if (len == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {Console.WriteLine("да");}
    else
    {Console.WriteLine("нет");}
}
else
{Console.WriteLine("введите пятизначное число");}
// task 2

Console.Clear();

Console.Write("Введите координату X(1): ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату Y(1): ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату Z(1): ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату X(2): ");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату Y(2): ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату Z(2): ");
double z2 = Convert.ToDouble(Console.ReadLine());

double S = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine(Math.Round(S, 2));

// Task 3

Console.Clear();

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
  Console.WriteLine($"{i} ^ 3 = {i * i * i} ");
