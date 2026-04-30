using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    public class BasicClass
    {

        public static void Main(string[] args)
        {
            // Object adalah instance dari class. Kita bisa membuat objek dari class Car yang sudah kita definisikan.

            // deklarasi variable reference untuk objek 

            Car myCar; // variable reference belum menyimpan memori untuk referen ke objek Car

            // new keyword adalah operator yang digunakan untuk membuat instance baru dari class dan menyimpan alamat referensi ke objek tersebut.

            myCar = new Car(); // membuat objek baru dari class Car dan menyimpan alamat referensi ke variable myCar


            Console.WriteLine("Model: " + myCar.model);
            Console.WriteLine("Year: " + myCar.year);
            Console.WriteLine("Color: " + myCar.color);
            Console.WriteLine("Calling StartEngine method:");
            myCar.StartEngine();

        }

    }

    // Defining a class named Car
    public class Car
    {
        // struktur didalam class

        // field (variabel yang ada di dalam class)

        public string model = "Tesla Model S";
        public int year = 2022;
        public string color = "Red";

        // method (fungsi yang ada di dalam class)
        public void StartEngine()
        {
            Console.WriteLine("The engine is starting...");
        }
    }
}
