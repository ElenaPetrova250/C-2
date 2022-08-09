Console.Write ("Введите первое число: ");
int NumberA = int.Parse(Console.ReadLine());
Console.Write ("Введите второе число: ");
int NumberB = int.Parse(Console.ReadLine());
Console.Write ("Введите третье число: ");
int NumberC = int.Parse(Console.ReadLine());
int max = int.Parse(Console.ReadLine());
if (NumberA>NumberB)
NumberA = max;
else NumberB = max;
if (NumberB>NumberC)
NumberB = max;
else NumberC = max;
if (NumberC>NumberA)
NumberC = max;
else NumberA = max;