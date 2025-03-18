class Program
{
    static void Main()
    {
        double A = 0;                
        double B = 3.14 / 2;         
        int M = 20;                     

        double H = (B - A) / M;

        for (int i = 0; i <= M; i++)
        {
            double x = A + i * H;      
            double F = Math.Sin(x) - Math.Cos(x);  
            Console.WriteLine($"F({x:F2}) = {F:F5}");
        }
    }
}