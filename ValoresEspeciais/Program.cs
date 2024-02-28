using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Short: max.= {short.MaxValue} min.= {short.MinValue}");
            Console.WriteLine($"Int: max.= {int.MaxValue} min.= {int.MinValue}");
            Console.WriteLine($"Sbyte: max.= {sbyte.MaxValue} min.= {sbyte.MinValue}");
            Console.WriteLine($"Byte: max.= {byte.MaxValue} min.= {byte.MinValue}");
            Console.WriteLine($"Long: max.= {long.MaxValue} min.= {long.MinValue}");
            Console.WriteLine($"Float: max.= {float.MaxValue} min.= {float.MinValue}");
            Console.WriteLine($"Double: max.= {double.MaxValue} min.= {double.MinValue}");
            Console.WriteLine($"Decimal: max.= {decimal.MaxValue} min.= {decimal.MinValue}");
            Console.WriteLine($"Ushort: max.= {ushort.MaxValue} min.= {ushort.MinValue}");
            Console.WriteLine($"Ulong: max.= {ulong.MaxValue} min.= {ulong.MinValue}");
            Console.WriteLine($"Uint: max.= {uint.MaxValue} min.= {uint.MinValue}");
            Console.WriteLine($"Char: max.= {char.MaxValue} min.= {char.MinValue}");

            //special types

            Console.WriteLine($"∞: neg.= {double.NegativeInfinity} pos.= {double.PositiveInfinity}");
            Console.WriteLine($"NaN: {float.NaN}");
            
        }
    }
}
