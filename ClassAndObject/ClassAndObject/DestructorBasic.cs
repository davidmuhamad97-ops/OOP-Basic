using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    public class DestructorBasic
    {
        /*
            Destructor adalah method khusus yang dipanggil ketika objek dihancurkan atau dihapus dari memori. Destructor digunakan untuk membersihkan sumber daya yang digunakan oleh objek sebelum objek tersebut dihapus dari memori.
            
            Berikut adalah beberapa poin penting tentang destructor:
            1. Destructor memiliki nama yang sama dengan kelas, tetapi diawali dengan tanda tilde (~).
            2. Destructor tidak memiliki parameter dan tidak memiliki akses modifier (seperti public, private, dll.).
            3. Destructor dipanggil secara otomatis oleh garbage collector ketika objek tidak lagi digunakan dan siap untuk dihapus dari memori.
         */

        public static void main()
        {
            SampleClass sample = new SampleClass();
            // Memaksa garbage collector untuk menghapus objek sample
            sample = null; // Menghapus referensi ke objek sample
            GC.Collect(); // Memanggil garbage collector secara manual

        }
    }

    class SampleClass
    {
        public SampleClass()
        {
            Console.WriteLine("Constructor called");
        }
        ~SampleClass()
        {
            Console.WriteLine("Destructor called");
        }
    }
}
