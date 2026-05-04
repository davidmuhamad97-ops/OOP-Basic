using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasic
{
    public class MultipleInheritance
    {
        public static void main()
        {
            Car car = new Car();

            car.StartEngine();
            car.ShiftGear();
        }
    }

    /*
        Multiple Inheritance adalah konsep dalam OOP di mana sebuah kelas dapat mewarisi sifat dan perilaku dari lebih dari satu kelas induk. 
        Namun, C# tidak mendukung multiple inheritance secara langsung untuk kelas, tetapi dapat dicapai melalui penggunaan interface.

        Alasan C# tidak mendukung multiple inheritance untuk kelas adalah untuk menghindari masalah yang dapat timbul, seperti konflik nama anggota atau ambiguitas dalam pewarisan.
     */



    interface IEngine
    {
        void StartEngine();
    }
    interface ITransmission
    {
        void ShiftGear();
    }

    class Car : IEngine, ITransmission
    {
        public void StartEngine()
        {
            Console.WriteLine("Engine started.");
        }
        public void ShiftGear()
        {
            Console.WriteLine("Gear shifted.");
        }
    }

}
