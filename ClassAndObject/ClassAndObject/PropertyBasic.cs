using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    public class PropertyBasic
    {
        public static void main()
        {
            Person person = new Person();
            person.Name = "John Doe"; // menggunakan property set untuk mengatur nilai
            person.Age = 30; // menggunakan property set untuk mengatur nilai
            Console.WriteLine($"Name: {person.Name}"); // menggunakan property get untuk membaca nilai

            Console.WriteLine($"Age: {person.Age}"); // menggunakan prloperty get untuk membaca nilai
            Console.WriteLine($"Address: {person.Address}"); // menggunakan property get untuk membaca nilai
            Console.WriteLine($"Full Address: {person.FullAddress}"); // menggunakan property get untuk membaca nilai dengan logika tambahan

            person.FullAddress = "Bandung"; // menggunakan property set untuk mengatur nilai
            Console.WriteLine($"Updated Full Address: {person.FullAddress}"); // menggunakan property get untuk membaca nilai dengan logika tambahan
            
        }
    }

    /*
        Property adalah bagian dari kelas yang berfungsi untuk mengatur nilai dari field / variable kelas seperti mengembalikan nilai dan membaca nilai.

        Berikut definisi dari property:
        1. Property adalah anggota kelas yang menyediakan mekanisme untuk membaca, menulis, atau menghitung nilai dari field pribadi.
        2. Property biasanya terdiri dari accessor get dan set yang digunakan untuk mengakses dan memodifikasi nilai dari field private.
        3. Property memungkinkan kita untuk mengontrol akses ke data dan menambahkan logika tambahan saat membaca atau menulis nilai, seperti validasi atau perhitungan.
        4. Meningkatkan enkapsulasi dengan menyembunyikan implementasi internal dan hanya menyediakan akses melalui property.

        Beberapa keuntungan menggunakan property:
        1. Enkapsulasi: Property memungkinkan kita untuk menyembunyikan implementasi internal dan hanya menyediakan akses melalui property, sehingga meningkatkan enkapsulasi.
        2. Validasi: Property memungkinkan kita untuk menambahkan logika validasi saat membaca atau menulis nilai, sehingga memastikan data yang valid dan konsisten.
        3. Kemudahan penggunaan: Property memberikan cara yang lebih mudah dan intuitif untuk mengakses dan memodifikasi data dibandingkan dengan menggunakan method getter dan setter tradisional.
     */

    class Person
    {
        private string name; // field private
        private int age; // field private
        private string address; // field private dengan nilai default

        // Property untuk mengakses field name
        public string Name
        {
            get { return name; } // accessor get untuk membaca nilai
            set { name = value; } // accessor set untuk menulis nilai
        }

        public int Age
        {
            get { return age; } // accessor get untuk membaca nilai
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age cannot be negative");
                }
                age = value; // accessor set untuk menulis nilai dengan validasi        
            }
        }

        // Property read-only untuk mengakses field address
        public string Address
        {
            get { return address; } // accessor get untuk membaca nilai
        }

        // Property read write untuk mengakses field address dengan logika tambahan
        public string FullAddress
        {
            get { return $"{address}, Indonesia"; } // accessor get untuk membaca nilai dengan logika tambahan
            set { address = value; } // accessor set untuk menulis nilai
        }

        public Person()
        {
            // Constructor untuk menginisialisasi objek

            // Mengatur nilai default untuk field address
            this.address = "Jakarta"; // nilai default untuk address
        }
    }
}
