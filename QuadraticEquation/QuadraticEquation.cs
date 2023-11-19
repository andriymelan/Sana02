using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

double a, b, c, D, x1, x2;
Console.WriteLine("Введіть число а: ");
double.TryParse(Console.ReadLine(),out a);
Console.WriteLine("Введіть число b: ");
double.TryParse(Console.ReadLine(), out b);
Console.WriteLine("Введіть число c: ");
double.TryParse(Console.ReadLine(), out c);
D = b * b - 4 * a * c;
Console.WriteLine($"Дискримінант : {D}");
if (D < 0)
    Console.WriteLine("Дискримінант менше нуля, розв'язків немає");
if (D == 0)
{
    x1 = -b / (2 * a);
    Console.WriteLine($"Розв'язанням є число {x1}");
}
if (D>0){
    x1 = -b - Math.Sqrt(D) / (2 * a);
    x2 = -b + Math.Sqrt(D) / (2 * a);
    Console.WriteLine($"Розв'язанням є числа {x1} і {x2}");
}