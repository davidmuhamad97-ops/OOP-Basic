using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    public class PassByValue
    {
        public static void main()
        {
            int number = 10;

            // Passing 'number' by value untuk method Increment. Perubahan pada parameter 'number' di dalam method Increment tidak akan mempengaruhi nilai asli dari variabel 'number' di sini.
            Increment(number); 
            Console.WriteLine("Original number after Increment method call: " + number); // Output will still be 10, demonstrating that 'number' was passed by value and not modified by the Increment method.
        }

        // Pass by value adalah mekanisme di mana nilai dari variabel dikirim ke metode atau fungsi, dan perubahan pada parameter di dalam metode tidak mempengaruhi nilai asli dari variabel yang dikirim.
        public static int Increment(int number)
        {
            number++; // Incrementing the parameter 'number' does not affect the original variable passed to this method.
            return number; // Return the incremented value
        }
    }
}
