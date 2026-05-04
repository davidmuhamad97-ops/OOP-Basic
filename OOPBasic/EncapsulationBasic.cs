using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasic
{
    public class EncapsulationBasic
    {
        public static void main()
        {
            Lingkaran lingkaran = new Lingkaran(5);
            Console.WriteLine(lingkaran.ToString());
        }
    }

    /*
        Encapsulation adalah salah satu prinsip dalam oop yang bertujuan untuk menyembunyikan data dan implementasi dari suatu objek,
        sehingga hanya dapat diakses melalui metode yang telah ditentukan.
        Dengan menggunakan encapsulation, kita dapat melindungi data dari akses yang tidak sah dan memastikan bahwa data hanya dapat diubah melalui metode yang telah ditentukan.

        Beberapa konsep utama encapsulation meliputi:
        1. Field disembunyikan melalui modifier akses private.Sehingga , data hanya dapat diakses melalui metode atau property yang telah ditentukan.
        2. Meningkatkan keamanan data dengan membatasi akses langsung ke field, sehingga mencegah perubahan yang tidak diinginkan.
        3. Memudahkan pemeliharaan kode dengan menyembunyikan implementasi internal, sehingga perubahan pada implementasi tidak mempengaruhi kode yang menggunakan objek tersebut.
        4. Access modfier seperti private, protected, internal, dan public digunakan untuk mengontrol akses ke anggota kelas.
     */

    class Lingkaran
    {
        private double radius; 
        const double PI = 3.14;
        public Lingkaran(double radius)
        {
            this.radius = radius;
        }

        public double Radius
        {
            set
            {
                if (value > 0)
                {
                    radius = value;
                }
                else
                {
                    throw new ArgumentException("Radius harus lebih besar dari 0");
                }
            }

            get { return radius; }
        }

        public double HitungLuas()
        {
            return Math.PI * radius * radius;
        }
        public double HitungKeliling()
        {
            return 2 * Math.PI * radius;
        }

        public override string ToString()
        {
            return $"Lingkaran dengan radius {radius}" +
                $"Luas = {this.HitungLuas()}" +
                $"Keliling = {this.HitungKeliling()}";
        }
    }
}
