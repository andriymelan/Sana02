using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

int n;
double res=0, fac=1;
Console.WriteLine("Введіть число: ");
int.TryParse(Console.ReadLine(), out n);
for (int i = 1; i <= n; i++)
{
    fac *= i;
    res += fac;
}
Console.WriteLine($"Відповідь: {res}");