using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasic
{
    public class InheritanceBasic
    {
        public static void main()
        {
            ElectricCar tesla = new ElectricCar("Tesla", "Model S", 2022, 100);

            tesla.displayInfo();
            tesla.Start();
            tesla.chargeBatery();

            GasCar toyota = new GasCar("Toyota", "Camry", 2021, 50);
            
            toyota.displayInfo();
            toyota.Start();
            toyota.fillTank();
        }
    }

    /*
        Inheritance adalah konsep dalam OOP yang memungkinkan sebuah kelas (child class) untuk mewarisi sifat dan perilaku dari kelas lain (parent class).
        Dengan inheritance, kita dapat membuat hierarki kelas yang lebih terstruktur dan menghindari duplikasi kode.

        Berikut cara kerja inheritance:
        1. Parent Class (Super Class): Ini adalah kelas yang memiliki sifat dan perilaku umum yang ingin diwariskan ke kelas lain. Contohnya, kita bisa memiliki kelas "Animal" sebagai parent class.
        2. Child Class (Sub Class): Ini adalah kelas yang mewarisi sifat dan perilaku dari parent class.
        3. Sub Class dapat menambahkan sifat dan perilaku tambahan yang spesifik untuk dirinya sendiri, atau bahkan mengubah perilaku yang diwarisi dari parent class.
        4. Sub Class dapat mengoverride metode dari parent class untuk memberikan implementasi yang berbeda.
        5. Sub Class dapat memperluas fungsionalitas parent class dengan menambahkan metode atau properti baru.
     */

     class Vehicler
     {
        private string make;
        private string model;
        private int year;

        public string Make { get => make; set => make = value; }
        public string Model { get => model; set => model = value; }
        public int Year { get => year; set => year = value; }

        public Vehicler(string make, string model, int year)
        {
            this.make = make;
            this.model = model;
            this.year = year;
        }

        public void Start()
        {
            Console.WriteLine("Vehicle is starting...");
        }

        public void Stop()
        {
            Console.WriteLine("Vehicle is stopping...");
        }

        public void displayInfo()
        {
            Console.WriteLine($"Make: {make}, Model: {model}, Year: {year}");
        }
    }

    class ElectricCar : Vehicler
    {
        private int batteryCapacity;

        public int BatteryCapacity { get => batteryCapacity; set => batteryCapacity = value; }

        // base keyword digunakan untuk memanggil konstruktor dari parent class (Vehicler) dan menginisialisasi properti yang diwarisi
        public ElectricCar(string make, string model, int year, int batteryCapacity) : base(make, model, year)
        {
            this.batteryCapacity = batteryCapacity;
        }

        public void chargeBatery()
        {
            Console.WriteLine("Electric car is charging...");
        }

        public void startEngine()
        {
            Console.WriteLine("Electric car is starting silently...");
        }
    }

    class GasCar : Vehicler
    {
        private int fuelTankCapacity;

        public int FuelTankCapacity { get => fuelTankCapacity; set => fuelTankCapacity = value; }
        public GasCar(string make, string model, int year, int fuelTankCapacity) : base(make, model, year)
        {
            this.fuelTankCapacity = fuelTankCapacity;
        }
        public void fillTank()
        {
            Console.WriteLine("Gas car is filling the tank...");
        }
        public void startEngine()
        {
            Console.WriteLine("Gas car is starting with engine noise...");
        }
    }


}
