Console.Write("Введите число а - ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b - ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("1 +\n2 -\n3 *\n4 /");
int choose = Convert.ToInt32(Console.ReadLine());
switch (choose)
{
    case 3:
        Console.WriteLine("Ответ: " + (a * b));
        break;
    default: Console.WriteLine("wrong"); break;
}
Console.ReadKey();
