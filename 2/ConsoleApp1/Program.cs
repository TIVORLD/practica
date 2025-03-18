Console.WriteLine("Введите радиус окружности:");
double radius = Convert.ToDouble(Console.ReadLine());

double circumference = 2 * Math.PI * radius; 
double area = Math.PI * Math.Pow(radius, 2); 

Console.WriteLine($"Длина окружности: {circumference}");
Console.WriteLine($"Площадь круга: {area}");