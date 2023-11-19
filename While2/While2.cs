using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

int n;
double res = 0;
Console.WriteLine("Введіть число: ");
int.TryParse(Console.ReadLine(), out n);
for (int i = 1; i <= n; i++)
{
    res += 1+1.0/Math.Pow(i,2);
}
Console.WriteLine($"Відповідь: {res}");