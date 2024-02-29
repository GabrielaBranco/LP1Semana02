using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me the height of a cylinder:");
            string altura = Console.ReadLine();
            float a = float.Parse(altura); 
            
            Console.WriteLine("Give me the radius of the cylinder:");
            string raio = Console.ReadLine();
            float r = float.Parse(raio);

            Console.WriteLine(MathF.PI * MathF.Pow(r,2) * a);
            Console.WriteLine(MathF.PI * 2 * r * (r + a));
        }
    }
}
