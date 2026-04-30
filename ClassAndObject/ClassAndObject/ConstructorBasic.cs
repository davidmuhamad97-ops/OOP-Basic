using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    public class ConstructorBasic
    {
        public static void main()
        {
            // Membuat objek menggunakan default constructor
            Person person1 = new Person();
            Console.WriteLine($"Name: {person1.Name}, Population: {Person.Population}");

            // Membuat objek menggunakan parameterized constructor
            Person person2 = new Person("Alice");
            Console.WriteLine($"Name: {person2.Name}, Population: {Person.Population}");

            // Membuat objek menggunakan copy constructor
            Person person3 = new Person(person2);
            Console.WriteLine($"Name: {person3.Name}, Population: {Person.Population}");

            // Mengakses anggota statis
            Console.WriteLine($"Population: {Person.Population}");
        }

        // Constructor adalah method khusus yang dipanggil ketika objek dibuat.
        // Constructor digunakan untuk menginisialisasi objek dengan nilai awal atau melakukan setup yang diperlukan saat objek dibuat.

        /*
              Jenis jenis Constructor:
                1. Default Constructor: Constructor tanpa parameter yang secara otomatis disediakan oleh compiler.
                2. Parameterized Constructor: Constructor yang memiliki parameter untuk menginisialisasi objek dengan nilai tertentu.
                3. Copy Constructor: Constructor yang digunakan untuk membuat objek baru dengan menyalin nilai dari objek yang sudah ada (tidak didukung secara langsung di C#, tetapi dapat diimplementasikan secara manual).
                4. Static Constructor: Constructor yang digunakan untuk menginisialisasi anggota statis dari kelas, dipanggil sekali sebelum anggota statis diakses atau instance pertama dibuat.
         */

        class Person
        {

            public string Name { get; set; }
            public static int Population { get; private set; }

            // default constructor
            public Person()
            {
                Console.WriteLine("Default constructor called");
                this.Name = "Unknown";
            }

            // parameterized constructor
            public Person(string name)
            {
                this.Name = name;
            }

            // copy constructor (manual implementation)
            public Person(Person other)
            {
                this.Name = other.Name;
            }

            // static constructor
            static Person()
            {
                Console.WriteLine("Static constructor called");
                Population = 0;
            }
        }
    }
}
