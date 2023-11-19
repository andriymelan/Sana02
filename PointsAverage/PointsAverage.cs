using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

double first, second, third, fourth, fifth, avarage;
Console.WriteLine("Введіть оцінки від 0 до 100");
Console.WriteLine("Перша оцінку: ");
double.TryParse(Console.ReadLine(), out first);
Console.WriteLine("Друга оцінка: ");
double.TryParse(Console.ReadLine(), out second);
Console.WriteLine("Третя оцінка: ");
double.TryParse(Console.ReadLine(), out third);
Console.WriteLine("Четверта оцінка: ");
double.TryParse(Console.ReadLine(), out fourth);
Console.WriteLine("п'ята оцінка: ");
double.TryParse(Console.ReadLine(), out fifth);
avarage = (first + second + third + fourth + fifth) / 5;
if (0 > first || 100 < first || 0 > second || 100 < second || 0 > third || 100 < third || 0 > fourth || 100 < fourth || 0 > fifth || 100 < fifth)
    Console.WriteLine("Помилка");
else if (avarage > 50)
    Console.WriteLine("Студент допущений до екзамену");
else 
    Console.WriteLine("Студент не допущений до екзамену");