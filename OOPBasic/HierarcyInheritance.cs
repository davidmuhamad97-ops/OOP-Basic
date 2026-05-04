using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasic
{
    public class HierarcyInheritance
    {
        public static void main()
        {

        }
    }

    /*
        Hierarchical Inheritance adalah konsep dalam OOP di mana beberapa kelas (child class) mewarisi sifat dan perilaku dari satu kelas induk (parent class).
        Dalam hierarchical inheritance, kita memiliki satu parent class yang menjadi dasar untuk beberapa child class
        Setiap child class dapat menambahkan sifat dan perilaku tambahan yang spesifik untuk dirinya sendiri, atau bahkan mengubah perilaku yang diwarisi dari parent class.

        Keuntungan Hierarchical Inheritance:
        1. Reusability: Dengan hierarchical inheritance, kita dapat menghindari duplikasi kode dengan mewariskan sifat dan perilaku umum dari parent class ke beberapa child class.
        2. Organization: Hierarchical inheritance membantu dalam mengorganisir kode dengan membuat struktur kelas yang lebih terstruktur dan mudah dipahami.
        3. Extensibility: Dengan hierarchical inheritance, kita dapat dengan mudah menambahkan kelas baru yang mewarisi sifat dan perilaku dari parent class tanpa harus mengubah kode yang sudah ada.

     */

    class vehicle
    {
        public void Start()
        {
            Console.WriteLine("Vehicle is starting...");
        }
    }

    class Car2 : vehicle
    {
        public void Drive()
        {
            Console.WriteLine("Car is driving...");
        }
    }

    class Motorcycle : vehicle
    {
        public void Ride()
        {
            Console.WriteLine("Motorcycle is riding...");
        }
    }

    class Honda : Motorcycle
    {
        public void DisplayBrand()
        {
            Console.WriteLine("This is a Honda motorcycle.");
        }
    }

    class Yamaha : Motorcycle
    {
        public void DisplayBrand()
        {
            Console.WriteLine("This is a Yamaha motorcycle.");
        }
    }
}
