using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasic
{
    public class Polymorphysm
    {
        public static void main()
        {

            // Polimerfisme dengan overloading

            Kalkulator kalkulator = new Kalkulator();
            int hasil1 = kalkulator.Tambah(5, 10); // Memanggil metode Tambah dengan parameter int
            double hasil2 = kalkulator.Tambah(3.5, 4.5); // Memanggil metode Tambah dengan parameter double

            Console.WriteLine("Hasil penjumlahan int: " + hasil1); // Output: Hasil penjumlahan int: 15
            Console.WriteLine("Hasil penjumlahan double: " + hasil2); // Output: Hasil penjumlahan double: 8

            // Polimerfisme dengan override

            BangunDatar persegi = new Persegi(4);
            Console.WriteLine("Luas persegi: " + persegi.hitungLuas()); // Output: Luas persegi: 16
            Console.WriteLine("Keliling persegi: " + persegi.hitungKeliling()); // Output: Keliling persegi: 16

            BangunDatar lingkaran = new Lingkaran2(3);
            Console.WriteLine("Luas lingkaran: " + lingkaran.hitungLuas()); // Output: Luas lingkaran: 28.2743338823081
            Console.WriteLine("Keliling lingkaran: " + lingkaran.hitungKeliling()); // Output: Keliling lingkaran: 18.8495559215388
        }
    }

    /*
        Polymorfisme adalah salah satu konsep dasar pada OOP yang memungkinkan objek untuk memiliki banyak bentuk.
        Polimorfisme memungkinkan kita menggunakan metode yang sama pada objek yang berbeda, sehingga kita dapat menulis kode yang lebih fleksibel dan mudah dipelihara.

        Berikut manfaat dari Polymorfisme:
        1. Mendorong keterkaitan yang longgar: Anda berinteraksi dengan abstraksi (interface atau kelas dasar) bukan implementasi konkret, sehingga memungkinkan untuk mengubah implementasi tanpa mempengaruhi kode yang menggunakan abstraksi tersebut.
        2. Meningkatkan fleksibilitas dan pemeliharaan kode: Dengan menggunakan polimorfisme kita dapat menerapkan perilaku berbeda tanpa memodifikasi kode yang sudah ada, sehingga mendukung prinsip Open/Closed.
        3. Meningkatkan skalabilitas: Sistem dapat dikembangkan dengan baik dengan menambahkan berbagai fiture dengan danpak seminimal mungkin perubahan pada kode yang sudah ada.
        4. Memungkinkan perluasan : Dengan menggunakan polimorfisme, kita dapat menambahkan kelas baru yang mengimplementasikan interface atau mewarisi kelas dasar tanpa harus menyentuh logika inti bisnis.
     
        Overloading adalah bentuk polimorfisme yang memungkinkan kita untuk memiliki beberapa metode dengan nama yang sama tetapi dengan parameter yang berbeda dalam kelas yang sama. 
        Overloading memungkinkan kita untuk menggunakan metode yang sama untuk melakukan tugas yang berbeda berdasarkan jenis atau jumlah argumen yang diberikan.

        Override adalah bentuk polimorfisme yang memungkinkan kita untuk mengganti implementasi metode yang diwarisi dari kelas dasar dengan implementasi yang spesifik untuk kelas turunan.
       
     */

    class Kalkulator
    {
        public int Tambah(int a, int b)
        {
            return a + b;
        }

        // Overloading metode Tambah dengan parameter yang berbeda
        public double Tambah(double a, double b)
        {
            return a + b;
        }
    }

    class BangunDatar 
    {

        // virtual keyword digunakan untuk menandai metode yang dapat di override oleh kelas turunan
        public virtual double hitungLuas() 
        {
            return 0.0;
        }

        public virtual double hitungKeliling() 
        {
            return 0.0;
        }
    }

    class Persegi : BangunDatar
    {
        private double sisi;

        public Persegi(double sisi)
        {
            this.sisi = sisi;
        }

        // override keyword digunakan untuk mengganti implementasi metode yang diwarisi dari kelas dasar
        public override double hitungLuas()
        {
            return sisi * sisi;
        }
        public override double hitungKeliling()
        {
            return 4 * sisi;
        }
    }

    class Lingkaran2 : BangunDatar
    {
        private double radius;
        public Lingkaran2(double radius)
        {
            this.radius = radius;
        }
        public override double hitungLuas()
        {
            return Math.PI * radius * radius;
        }
        public override double hitungKeliling()
        {
            return 2 * Math.PI * radius;
        }
    }
}
