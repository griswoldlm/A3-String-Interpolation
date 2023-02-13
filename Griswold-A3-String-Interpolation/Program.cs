using Microsoft.VisualBasic;
using System.Diagnostics.CodeAnalysis;

namespace Griswold_A3_String_Interpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1. January 22, 2019 (right aligned in a 40 character field)
            Console.WriteLine($"{DateTime.Now,40: MMMM d, yyyy}");

            // 2. 2019.01.22
            Console.WriteLine($"{DateTime.Now,0:yyyy.MM.d}");

            // 3. Day 22 of January, 2019
            var now = DateTime.Now;
            Console.WriteLine($"Day {now:dd} of {now:mmmm}, {now:yyyy}");

            // 4. Year: 2019, Month: 01, Day: 22
            Console.WriteLine($"Year: {now:yyyy}, Month: {now:mm}, Day:{now:dd}");

            // 5. Tuesday (10 spaces total, right aligned)
            Console.WriteLine($"{now, 10:dddd}");

            // 6. 11:01 PM             Tuesday (10 spaces total for each including the day-of-week, both right-aligned)
            Console.WriteLine($"{now, 10:h:mm tt} {now,10:dddd}");

            // 7. h:11, m:01, s:27
            Console.WriteLine($"h:{now: h}, m:{now:mm}, s:{now:ss}");

            // 8. 2019.01.22.11.01.27
            Console.WriteLine($"{DateTime.Now:yyyy.MM.dd.h.mm.ss}");

            // If you have PI (3.1415) - use var pi = Math.PI;
            var pi = Math.PI;

            // 1. Output as Currency
            Console.WriteLine($"{pi:c}");

            // 2.Output as right-alined (10 spaces), number with 3 decimal places
            Console.WriteLine($"{pi, 10:n3}");
             
        }
    }
}