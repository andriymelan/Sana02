using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

int n;
double res=0;
Console.WriteLine("Введіть число: ");
int.TryParse(Console.ReadLine(), out n);
for (int i = 1; i <= n; i++)
{
    res += Math.Pow(-1.0, i) / (2 * i + 1);
}
Console.WriteLine($"Відповідь: {res}");