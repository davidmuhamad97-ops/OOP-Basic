using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    public class MethodBasic
    {
        public static void main()
        {
            MethodBasic methodBasic = new MethodBasic();

            int x = methodBasic.Add(5, 10);
            Console.WriteLine("Hasil penjumlahan: " + x);

            int y = MethodBasic.Multiply(5, 10);
            Console.WriteLine("Hasil perkalian: " + y);
        }

        // Method adalah fungsi yang didefinisikan di dalam class. Method digunakan untuk melakukan aksi atau operasi tertentu pada objek. Method dapat memiliki parameter dan mengembalikan nilai.
        // Signature method terdiri dari nama method, tipe data parameter, dan tipe data return (jika ada).

        // deklarasi method dengan parameter dan return type
        public int Add(int a, int b)
        {
            return a + b;
        }

        // acces modifier method => menentukan tingkat aksesibilitas method. Contoh: public, private, protected, internal, dll.
        // return type method => menentukan tipe data yang akan dikembalikan oleh method. Contoh: void (tidak mengembalikan nilai), int, string, dll.
        // method name => nama method harus sesuai dengan aturan penamaan di C#. Nama method biasanya menggunakan PascalCase.
        // parameter method => variabel yang digunakan untuk menerima input saat method dipanggil. Parameter dideklarasikan di dalam tanda kurung setelah nama method, dan dapat memiliki tipe data dan nama yang sesuai.


        // Static method adalah method yang dapat dipanggil tanpa harus membuat objek dari class.
        // Static method biasanya digunakan untuk operasi yang tidak bergantung pada data instance dari class.

        public static int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
