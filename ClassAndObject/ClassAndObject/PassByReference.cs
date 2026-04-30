using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    public class PassByReference
    {
        public static void main()
        {
            int number = 10;
            Increment(ref number); // Passing 'number' by reference untuk method Increment. Perubahan pada parameter 'number' di dalam method Increment akan mempengaruhi nilai asli dari variabel 'number' di sini.
            Console.WriteLine("Original number after Increment method call: " + number); // Output will be 11, demonstrating that 'number' was passed by reference and modified by the Increment method.

            int x = 5;
            int y = 10;
            Console.WriteLine($"Before swap: x = {x}, y = {y}");
            Swap(ref x, ref y); // Passing 'x' and 'y' by reference untuk method Swap. Perubahan pada parameter 'a' dan 'b' di dalam method Swap akan mempengaruhi nilai asli dari variabel 'x' dan 'y' di sini.
            Console.WriteLine($"After swap: x = {x}, y = {y}");

            int a, b;
            Console.WriteLine("Getting values using GetValues method...");
            GetValues(out a, out b); // Passing 'a' and 'b' as out parameters untuk method GetValues. Nilai dari parameter 'a' dan 'b' akan diinisialisasi di dalam method GetValues dan dikembalikan ke variabel 'a' dan 'b' di sini.
            Console.WriteLine($"Values obtained from GetValues method: a = {a}, b = {b}");
        }

        // Pass by reference adalah mekanisme di mana alamat memori dari variabel dikirim ke metode atau fungsi, sehingga perubahan pada parameter di dalam metode akan mempengaruhi nilai asli dari variabel yang dikirim.
        public static int Increment(ref int number)
        {
            number++; // Parameter number di sini adalah referensi ke variabel asli yang dikirim, sehingga perubahan pada parameter ini akan mempengaruhi nilai asli dari variabel tersebut.
            return number; // Return the incremented value
        }

        public static void Swap(ref int a, ref int b)
        {
            int swapp = a;
            a = b;
            b = swapp;
        }

        // out parameter adalah jenis parameter yang digunakan untuk mengembalikan nilai dari metode.
        // Parameter out harus diinisialisasi di dalam metode sebelum dikembalikan, dan tidak perlu diinisialisasi saat dipanggil.

        public static void GetValues(out int a, out int b)
        {
            a = 5; // Inisialisasi parameter out 'a' di dalam metode
            b = 10; // Inisialisasi parameter out 'b' di dalam metode
        }
    }
}
